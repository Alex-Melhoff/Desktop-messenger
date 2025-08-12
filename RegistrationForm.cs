using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoX.DataBaseWorker;

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
            string nickname = Convert.ToString(Nickname_txtbx.Text.TrimStart(' ').TrimEnd(' '));
            string email = Convert.ToString(Email_txtbx.Text.TrimStart(' ').TrimEnd(' '));
            string password = Convert.ToString(Password_txtbx.Text.TrimStart(' ').TrimEnd(' '));

            /// проверка никнейма, email и пароля на корректность ///
            if (!Config.UserDataAreCorrect(nickname, email, password))
            {
                return;
            }
            /// проверка email и пароля в базе данных ///
            if (DBWorker.AddUser(nickname, email, password, Convert.ToString(DateTime.Now)) == false) // добавление пользователя
            {
                MessageBox.Show("Пользователь с таким email уже существует");
                // очистка полей
                Email_txtbx.Text = string.Empty;
                Nickname_txtbx.Text = string.Empty;
                Password_txtbx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Успешная регистрация!");
                LogIn_btn.Visible = true;
            }
        }
    }
}
