namespace MonoX
{
    public partial class Form1 : Form
    {
        private bool isVisible = true;
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
            MessageBox.Show("������������ �������!");
        }

        private void ChangeVisibility_LogInRegister_pnl(bool isVisible)
        {
            LogIn_btn.Visible = isVisible;
            Register_btn.Visible = isVisible;
        }

        private void button1_Click(object sender, EventArgs e) // ��� ������
        {
            isVisible = !isVisible;
            ChangeVisibility_LogInRegister_pnl(isVisible);
        }
    }
}
