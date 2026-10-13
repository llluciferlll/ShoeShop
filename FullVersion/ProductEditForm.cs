using System.Data;

namespace ShoeShop
{
    public partial class ProductEditForm : Form
    {
        private readonly DataRow row;
        private readonly int productId;
        private string photo = "";
        private string newPhotoFile;

        // row == null — добавление нового товара
        public ProductEditForm(DataRow row)
        {
            InitializeComponent();
            Icon = Icon.FromHandle(new Bitmap("Icon.png").GetHicon());
            this.row = row;
            // ID нового товара = максимальный ID в БД + 1
            productId = row == null ? (int)Db.Query("select coalesce(max(id), 0) + 1 from product").Rows[0][0] : (int)row["id"];
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            Db.FillComboBox(cmbCategory, "select id, name from category");
            Db.FillComboBox(cmbManufacturer, "select id, name from manufacturer");
            Db.FillComboBox(cmbSupplier, "select id, name from supplier");
            if (row == null)
            {
                Text = "ООО «Обувь» — Добавление товара";
                lblId.Visible = false;
                txtId.Visible = false;
                btnDelete.Visible = false;
                picPhoto.Image = Db.LoadImage("");
                return;
            }
            txtId.Text = productId.ToString();
            txtArticle.Text = row["article"].ToString();
            txtName.Text = row["name"].ToString();
            cmbCategory.SelectedValue = row["category_id"];
            txtDescription.Text = row["description"].ToString();
            cmbManufacturer.SelectedValue = row["manufacturer_id"];
            cmbSupplier.SelectedValue = row["supplier_id"];
            numPrice.Value = (decimal)row["price"];
            txtUnit.Text = row["unit"].ToString();
            numQuantity.Value = (int)row["quantity"];
            numDiscount.Value = (int)row["discount"];
            photo = row["photo"].ToString();
            picPhoto.Image = Db.LoadImage(photo);
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            newPhotoFile = openFileDialog.FileName;
            picPhoto.Image = Db.LoadImage(newPhotoFile);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtArticle.Text == "" || txtName.Text == "" || txtUnit.Text == "")
            {
                MessageBox.Show("Заполните поля «Артикул», «Наименование» и «Единица измерения».", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPhotoFile != null)
            {
                // Новое фото уменьшаем до 300x200, сохраняем в папку приложения, старое удаляем
                string oldPhoto = photo;
                photo = DateTime.Now.Ticks + ".png";
                new Bitmap(Db.LoadImage(newPhotoFile), 300, 200).Save(photo);
                if (File.Exists(oldPhoto))
                    File.Delete(oldPhoto);
            }
            object[] values = { productId, txtArticle.Text, txtName.Text, txtUnit.Text, numPrice.Value, cmbSupplier.SelectedValue, cmbManufacturer.SelectedValue, cmbCategory.SelectedValue, (int)numDiscount.Value, (int)numQuantity.Value, txtDescription.Text, photo };
            if (row == null)
                Db.Query("insert into product (id, article, name, unit, price, supplier_id, manufacturer_id, category_id, discount, quantity, description, photo) values ($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12)", values);
            else
                Db.Query("update product set article = $2, name = $3, unit = $4, price = $5, supplier_id = $6, manufacturer_id = $7, category_id = $8, discount = $9, quantity = $10, description = $11, photo = $12 where id = $1", values);
            MessageBox.Show("Товар сохранён.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Db.Query("select * from order_item where product_id = $1", productId).Rows.Count > 0)
            {
                MessageBox.Show("Этот товар есть в заказах, поэтому удалить его нельзя.", "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Удалить товар? Это действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Db.Query("delete from product where id = $1", productId);
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
