namespace ShoeShop
{
    internal static class Program
    {
        // Данные вошедшего пользователя, доступны из любой формы
        public static int UserId;
        public static string FullName;
        public static string Role;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetDefaultFont(new Font("Times New Roman", 11F));
            // Любая ошибка показывается сообщением, приложение не закрывается аварийно
            Application.ThreadException += (sender, e) => MessageBox.Show("Произошла ошибка: " + e.Exception.Message + "\nПроверьте введённые данные и подключение к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Run(new LoginForm());
        }
    }
}
