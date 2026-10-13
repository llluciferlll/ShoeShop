using System.Data;
using Npgsql;

namespace ShoeShop
{
    internal static class Db
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Database=shoes;Username=postgres;Password=postgres";

        // Выполняет любой SQL-запрос; аргументы подставляются по порядку вместо $1, $2, $3...
        public static DataTable Query(string sql, params object[] args)
        {
            var command = new NpgsqlCommand(sql, new NpgsqlConnection(ConnectionString));
            foreach (var arg in args)
                command.Parameters.AddWithValue(arg);
            var table = new DataTable();
            new NpgsqlDataAdapter(command).Fill(table);
            return table;
        }

        // Заполняет выпадающий список из запроса вида "select id, name from ..."
        public static void FillComboBox(ComboBox comboBox, string sql)
        {
            comboBox.DataSource = Query(sql);
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
        }

        // Загружает картинку без блокировки файла (чтобы старое фото можно было удалить).
        // Если файла нет — возвращает заглушку picture.png
        public static Image LoadImage(string path)
        {
            if (!File.Exists(path))
                path = "picture.png";
            return Image.FromStream(new MemoryStream(File.ReadAllBytes(path)));
        }
    }
}
