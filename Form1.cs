namespace MonoX
{
    public partial class Form1 : Form
    {
        private bool LogInRegister_pnl_IsVisible = true;
        private bool LogIn_pnl_IsVisible = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������������ ������ �������!");
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("������������ �������!");
            LogInRegistration_pnl.Visible = !LogInRegister_pnl_IsVisible;
            LogIn_pnl.Visible = !LogIn_pnl_IsVisible;
            LogIn_pnl.Location = new Point(LogIn_pnl.Location.X, LogInRegistration_pnl.Location.Y);
        }

    }
}
