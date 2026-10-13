using System.Data;

namespace ShoeShop
{
    public partial class OrderEditForm : Form
    {
        private readonly DataRow row;
        private readonly int orderId;

        // row == null — добавление нового заказа
        public OrderEditForm(DataRow row)
        {
            InitializeComponent();
            Icon = new Icon("Icon.ico");
            this.row = row;
            orderId = row == null ? (int)Db.Query("select coalesce(max(id), 0) + 1 from orders").Rows[0][0] : (int)row["id"];
        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            Db.FillComboBox(cmbPoint, "select id, address as name from pickup_point");
            cmbStatus.SelectedIndex = 0;
            if (row == null)
            {
                Text = "ООО «Обувь» — Добавление заказа";
                btnDelete.Visible = false;
                return;
            }
            txtArticles.Text = row["articles"].ToString();
            cmbStatus.Text = row["status"].ToString();
            cmbPoint.SelectedValue = row["point_id"];
            dtpOrder.Value = (DateTime)row["order_date"];
            dtpDelivery.Value = (DateTime)row["delivery_date"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Артикулы вводятся как в Excel: артикул, количество, артикул, количество...
            string[] parts = txtArticles.Text.Split(',');
            if (txtArticles.Text == "" || parts.Length % 2 != 0)
            {
                MessageBox.Show("Введите артикулы в формате: артикул, количество, артикул, количество.\nНапример: А112Т4, 2, F635R4, 2", "Неверный формат артикула", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            object[] values = { orderId, cmbStatus.Text, cmbPoint.SelectedValue, dtpOrder.Value.Date, dtpDelivery.Value.Date };
            if (row == null)
                Db.Query("insert into orders (id, status, point_id, order_date, delivery_date) values ($1, $2, $3, $4, $5)", values);
            else
                Db.Query("update orders set status = $2, point_id = $3, order_date = $4, delivery_date = $5 where id = $1", values);
            // Состав заказа перезаписываем целиком
            Db.Query("delete from order_item where order_id = $1", orderId);
            for (int i = 0; i < parts.Length; i += 2)
                Db.Query("insert into order_item (order_id, product_id, quantity) select $1, id, $3 from product where article = $2", orderId, parts[i].Trim(), int.Parse(parts[i + 1]));
            MessageBox.Show("Заказ сохранён.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить заказ? Это действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Db.Query("delete from order_item where order_id = $1", orderId);
            Db.Query("delete from orders where id = $1", orderId);
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
