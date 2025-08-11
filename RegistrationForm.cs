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
            this.Resize += RegisterForm_Resize;
            LogIn_btn.MouseEnter += OnMouseEnter_LogIn_btn;
            LogIn_btn.MouseLeave += OnMouseLeave_LogIn_btn;
            Register_btn.MouseEnter += OnMouseEnter_Register_btn;
            Register_btn.MouseLeave += OnMouseLeave_Register_btn;
        }
        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            FontResize(Register_Header_lbl, 14f);
            FontResize(Email_lbl, 8f);
            FontResize(Password_lbl, 8f);
            FontResize(Nickname_lbl, 8f);
            FontResize(LogIn_btn, 8f);
            FontResize(Register_btn, 7.8f); 
        }
        private void FontResize(Control control, float baseFontSize)
        {
            const int baseFormWidth = 1080; // Ширина формы, при которой используется baseFontSize

            float scaleFactor = (float)this.Width / baseFormWidth;
            float newFontSize = baseFontSize * Math.Min(scaleFactor, 1.5f); // Ограничиваем максимальный масштаб

            control.Font = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);

            // Центрируем текст после изменения размера
            control.Left = (this.ClientSize.Width - control.Width) / 2;
        }


        // Mouse events //
        private void OnMouseEnter_LogIn_btn(object sender, EventArgs e)
        {
            LogIn_btn.BackColor = Color.DarkGray;
        }
        private void OnMouseLeave_LogIn_btn(object sender, EventArgs e)
        {
            LogIn_btn.BackColor = Color.LightGray;
        }
        private void OnMouseEnter_Register_btn(object sender, EventArgs e)
        {
            Register_btn.BackColor = Color.DarkGray;
        }
        private void OnMouseLeave_Register_btn(object sender, EventArgs e)
        {
            Register_btn.BackColor = Color.LightGray;
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
