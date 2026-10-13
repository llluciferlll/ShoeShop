using System.Data;

namespace ShoeShop
{
    public partial class OrdersForm : Form
    {
        private readonly bool isAdmin = Program.Role == "Администратор";

        public OrdersForm()
        {
            InitializeComponent();
            Icon = new Icon("Icon.ico");
            lblUser.Text = Program.FullName;
            btnAdd.Visible = isAdmin;
            LoadOrders();
        }

        private void LoadOrders()
        {
            // articles — состав заказа одной строкой: "А112Т4, 2, F635R4, 2"
            var table = Db.Query("select o.*, p.address, (select string_agg(pr.article || ', ' || i.quantity, ', ') " +
                "from order_item i join product pr on pr.id = i.product_id where i.order_id = o.id) as articles " +
                "from orders o join pickup_point p on p.id = o.point_id order by o.id");
            flowOrders.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                var card = new OrderCard(row);
                if (isAdmin)
                    card.Click += (s, args) => OpenEditor(row);
                flowOrders.Controls.Add(card);
            }
        }

        private void OpenEditor(DataRow row)
        {
            new OrderEditForm(row).ShowDialog();
            LoadOrders();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenEditor(null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
