namespace ShoeShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Icon = new Icon("Icon.ico");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var table = Db.Query("select u.id, u.full_name, r.name from users u join role r on r.id = u.role_id where u.login = $1 and u.password = $2", txtLogin.Text, txtPassword.Text);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Неверный логин или пароль.\nПроверьте раскладку клавиатуры и повторите ввод.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var user = table.Rows[0];
            OpenProducts((int)user["id"], user["full_name"].ToString(), user["name"].ToString());
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            OpenProducts(0, "Гость", "Гость");
        }

        private void OpenProducts(int userId, string fullName, string role)
        {
            Program.UserId = userId;
            Program.FullName = fullName;
            Program.Role = role;
            Hide();
            new ProductsForm().ShowDialog();
            txtPassword.Clear();
            Show();
        }
    }
}
