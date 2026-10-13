using System.Data;

namespace ShoeShop
{
    public partial class ProductsForm : Form
    {
        private readonly bool isAdmin = Program.Role == "Администратор";
        private readonly bool isManager = Program.Role == "Менеджер";

        public ProductsForm()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(new Bitmap("Icon.png").GetHicon());
            lblUser.Text = Program.FullName;
            panelFilter.Visible = isAdmin || isManager;
            btnOrders.Visible = isAdmin || isManager;
            btnAdd.Visible = isAdmin;
            cmbSupplier.Items.Add("Все поставщики");
            foreach (DataRow row in Db.Query("select name from supplier order by name").Rows)
                cmbSupplier.Items.Add(row["name"]);
            cmbSort.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
        }

        // Вызывается при каждом изменении поиска, фильтра или сортировки
        private void LoadProducts(object sender, EventArgs e)
        {
            // Умножение на 1 или -1 даёт сортировку по возрастанию или по убыванию
            var table = Db.Query("select p.*, c.name as category, m.name as manufacturer, s.name as supplier from product p " +
                "join category c on c.id = p.category_id join manufacturer m on m.id = p.manufacturer_id join supplier s on s.id = p.supplier_id " +
                "where concat_ws(' ', p.article, p.name, p.unit, p.description, c.name, m.name, s.name) ilike $1 " +
                "and ($2 = 'Все поставщики' or s.name = $2) order by p.quantity * $3, p.id",
                "%" + txtSearch.Text + "%", cmbSupplier.Text, cmbSort.SelectedIndex == 0 ? 1 : -1);
            flowProducts.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                var card = new ProductCard(row);
                if (isAdmin)
                    card.Click += (s, args) => OpenEditor(row);
                flowProducts.Controls.Add(card);
            }
        }

        private void OpenEditor(DataRow row)
        {
            // ShowDialog не даёт открыть второе окно редактирования, пока открыто первое
            new ProductEditForm(row).ShowDialog();
            LoadProducts(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenEditor(null);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new OrdersForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
