using Npgsql;

namespace ShoeShop
{
    public partial class Login : Form
    {
        string connStr = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=1234";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT role FROM users WHERE login = @l AND password = @p", conn);
            cmd.Parameters.AddWithValue("@l", textBox1.Text);
            cmd.Parameters.AddWithValue("@p", textBox2.Text);
            var role = cmd.ExecuteScalar();
            if (role == null)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenMain(role.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenMain("Гость");
        }

        void OpenMain(string role)
        {
            Hide();
            new Form1(role).ShowDialog();
            textBox2.Clear();
            Show();
        }
    }
}
