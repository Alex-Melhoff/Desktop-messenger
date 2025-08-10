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
            // MessageBox.Show("������������ ������ �������!");
            
            var RegForm = new RegistrationForm();
            RegForm.Show();
            this.Hide();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("������������ �������!");
            LogInRegistration_pnl.Visible = !LogInRegister_pnl_IsVisible;
            LogIn_pnl.Visible = !LogIn_pnl_IsVisible;
            LogIn_pnl.Location = new Point(LogIn_pnl.Location.X, LogInRegistration_pnl.Location.Y);
        }

        private void LogIn_Continue_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
            string email = Email_txtbx.Text.TrimStart(' ').TrimEnd(' ');
            string password = Password_txtbx.Text.TrimStart(' ').TrimEnd(' ');

            if (email == string.Empty ||  // ���� ����(����) �� ���������(��)
                password == string.Empty)
            {
                MessageBox.Show("��������� ��� ����");
                return;
            }
            if (!Config.EmailEndings.Any(email.Contains) ||  // ���� ��� ���������� ��������� email 
                email.IndexOf('@') == 0 ||                   // ��� ���� '@' ����� ������
                email.Count(x => x == '@') > 1 ||            // ��� ���� '@' �� ����
                email.Contains(' '))                         // ��� ������ email ���� �������
            {
                MessageBox.Show("������������ email");
                return;
            }
            if (password.Length < 8) MessageBox.Show("����� ������ ������ 8 ��������");
            else if (!password.Any(c => Config.IsLetter(c))) MessageBox.Show("������ �� �������� ����");
            else if (!password.Any(c => char.IsDigit(c))) MessageBox.Show("������ �� �������� ����");
            else if (!password.Any(c => c == '-' || c == '_')) MessageBox.Show("������ �� �������� �������� '-' ��� '_'");

            else
            {
                /// �������� email � ������ � ���� ������ ///
                MessageBox.Show("����������� � �������� ������!");
            }


        }
    }
}
