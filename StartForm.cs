namespace MonoX
{
    public partial class StartForm : Form
    {
        private bool LogInRegister_pnl_IsVisible = true;
        private bool LogIn_pnl_IsVisible = false;
        public StartForm()
        {
            InitializeComponent();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Регистрируем нового хозяина!");
            
            var RegForm = new RegistrationForm();
            RegForm.Show();
            this.Hide();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Приветствуем хозяина!");
            LogInRegistration_pnl.Visible = !LogInRegister_pnl_IsVisible;
            LogIn_pnl.Visible = !LogIn_pnl_IsVisible;
            LogIn_pnl.Location = new Point(LogIn_pnl.Location.X, LogInRegistration_pnl.Location.Y);
        }

        private void LogIn_Continue_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
            string email = Email_txtbx.Text.TrimStart(' ').TrimEnd(' ');
            string password = Password_txtbx.Text.TrimStart(' ').TrimEnd(' ');

            if (email == string.Empty ||  // если поле(поля) не заполнено(ны)
                password == string.Empty)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (!Config.EmailEndings.Any(email.Contains) ||  // если нет привычного окончания email 
                email.IndexOf('@') == 0 ||                   // или знак '@' стоит первым
                email.Count(x => x == '@') > 1 ||            // или знак '@' не один
                email.Contains(' '))                         // или внутри email есть пробелы
            {
                MessageBox.Show("Некорректный email");
                return;
            }
            if (password.Length < 8) MessageBox.Show("Длина пароля меньше 8 символов");
            else if (!password.Any(c => Config.IsLetter(c))) MessageBox.Show("Пароль не содержит букв");
            else if (!password.Any(c => char.IsDigit(c))) MessageBox.Show("Пароль не содержит цифр");
            else if (!password.Any(c => c == '-' || c == '_')) MessageBox.Show("Пароль не содержит символов '-' или '_'");

            else
            {
                /// проверка email и пароля в базе данных ///
                MessageBox.Show("Поздравляем с успешным входом!");
            }


        }
    }
}
