using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoX
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            var StartForm = new StartForm();
            StartForm.Show();
            this.Close();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string nickname = Nickname_txtbx.Text.TrimStart(' ').TrimEnd(' ');
            string email = Email_txtbx.Text.TrimStart(' ').TrimEnd(' ');
            string password = Password_txtbx.Text.TrimStart(' ').TrimEnd(' ');

            if (nickname == string.Empty ||
                email == string.Empty ||  // если поле(поля) не заполнено(ны)
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
                MessageBox.Show("Поздравляем с успешной регистрацией!");
                LogIn_btn.Visible = true;
            }
        }
    }
}
