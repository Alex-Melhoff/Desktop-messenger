using MonoX.DataBaseWorker;

namespace MonoX
{
    public partial class StartForm : Form
    {
        private bool LogInRegister_pnl_IsVisible = true;
        private bool LogIn_pnl_IsVisible = false;
        public StartForm()
        {
            InitializeComponent();
            this.Resize += StartForm_Resize;
            LogIn_btn.MouseEnter += OnMouseEnter_LogIn_btn;
            LogIn_btn.MouseLeave += OnMouseLeave_LogIn_btn;
            Register_btn.MouseEnter += OnMouseEnter_Register_btn;
            Register_btn.MouseLeave += OnMouseLeave_Register_btn;
            LogIn_Continue_btn.MouseEnter += OnMouseEnter_LogIn_Continue_btn;
            LogIn_Continue_btn.MouseLeave += OnMouseLeave_LogIn_Continue_btn;
        }

        private void StartForm_Resize(object sender, EventArgs e)
        {
            FontResize(Header_lbl, 14f);
            FontResize(Email_lbl, 8f);
            FontResize(Password_lbl, 8f);
            FontResize(LogIn_Continue_btn, 8f);
            FontResize(LogIn_btn, 8f);
            FontResize(Register_btn, 8f);
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
        private void OnMouseEnter_LogIn_Continue_btn(object sender, EventArgs e)
        {
            LogIn_Continue_btn.BackColor = Color.DarkGray;
        }
        private void OnMouseLeave_LogIn_Continue_btn(object sender, EventArgs e)
        {
            LogIn_Continue_btn.BackColor = Color.LightGray;
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
            //LogIn_pnl.Location = new Point(LogIn_pnl.Location.X, LogInRegistration_pnl.Location.Y);
            Authorization_pnl.SetRow(LogIn_pnl, 3);
            Authorization_pnl.SetRowSpan(LogIn_pnl, 2);
        }

        private void LogIn_Continue_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
            string email = Email_txtbx.Text.TrimStart(' ').TrimEnd(' ');
            string password = Password_txtbx.Text.TrimStart(' ').TrimEnd(' ');

            if (!Config.UserDataAreCorrect(email, password))
            {
                return;
            }

            if (DBWorker.FindUser(email, password) == false) // поиск пользователя
            {
                MessageBox.Show("Пользователя с такими данными не существует");
                // очистка полей
                Email_txtbx.Text = string.Empty;
                Password_txtbx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Успешный вход!");
                LogIn_btn.Visible = true;

                var chatForm = new ChatForm();
                chatForm.Show();
                this.Hide();
            }


        }


        

       
    }
}
