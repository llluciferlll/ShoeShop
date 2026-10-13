using System.Data;
using Npgsql;

namespace ShoeShop
{
    public partial class Form1 : Form
    {
        DataTable dt;
        string connStr = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=1234";

        public Form1(string role)
        {
            InitializeComponent();
            label1.Text = role;
            if (role == "Администратор")
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                comboBox1.Items.Add("users");
            }
            comboBox1.Items.Add("products");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            new NpgsqlDataAdapter("select * from " + comboBox1.Text, connStr).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var da = new NpgsqlDataAdapter("select * from " + comboBox1.Text, connStr);
            new NpgsqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Изменения сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
