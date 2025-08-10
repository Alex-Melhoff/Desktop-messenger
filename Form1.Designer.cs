namespace MonoX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Authorization_pnl = new Panel();
            LogIn_pnl = new TableLayoutPanel();
            Password_lbl = new Label();
            Email_lbl = new Label();
            Email_txtbx = new TextBox();
            Password_txtbx = new MaskedTextBox();
            LogInRegistration_pnl = new TableLayoutPanel();
            Register_btn = new Button();
            LogIn_btn = new Button();
            Header_lbl = new Label();
            Authorization_pnl.SuspendLayout();
            LogIn_pnl.SuspendLayout();
            LogInRegistration_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // Authorization_pnl
            // 
            Authorization_pnl.BackColor = Color.WhiteSmoke;
            Authorization_pnl.Controls.Add(LogIn_pnl);
            Authorization_pnl.Controls.Add(LogInRegistration_pnl);
            Authorization_pnl.Controls.Add(Header_lbl);
            Authorization_pnl.Location = new Point(500, 0);
            Authorization_pnl.Name = "Authorization_pnl";
            Authorization_pnl.Size = new Size(920, 1080);
            Authorization_pnl.TabIndex = 0;
            // 
            // LogIn_pnl
            // 
            LogIn_pnl.ColumnCount = 3;
            LogIn_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            LogIn_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            LogIn_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            LogIn_pnl.Controls.Add(Password_lbl, 0, 2);
            LogIn_pnl.Controls.Add(Email_lbl, 0, 0);
            LogIn_pnl.Controls.Add(Email_txtbx, 2, 0);
            LogIn_pnl.Controls.Add(Password_txtbx, 2, 2);
            LogIn_pnl.Location = new Point(243, 464);
            LogIn_pnl.Name = "LogIn_pnl";
            LogIn_pnl.RowCount = 3;
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            LogIn_pnl.Size = new Size(425, 125);
            LogIn_pnl.TabIndex = 3;
            // 
            // Password_lbl
            // 
            Password_lbl.Anchor = AnchorStyles.Left;
            Password_lbl.AutoSize = true;
            Password_lbl.BackColor = Color.Transparent;
            Password_lbl.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_lbl.Location = new Point(3, 86);
            Password_lbl.Name = "Password_lbl";
            Password_lbl.Size = new Size(90, 27);
            Password_lbl.TabIndex = 5;
            Password_lbl.Text = "Пароль";
            Password_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Email_lbl
            // 
            Email_lbl.Anchor = AnchorStyles.Left;
            Email_lbl.AutoSize = true;
            Email_lbl.BackColor = Color.Transparent;
            Email_lbl.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Email_lbl.Location = new Point(3, 11);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(77, 27);
            Email_lbl.TabIndex = 4;
            Email_lbl.Text = "Email";
            Email_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Email_txtbx
            // 
            Email_txtbx.Anchor = AnchorStyles.None;
            Email_txtbx.BackColor = Color.White;
            Email_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Email_txtbx.Location = new Point(172, 11);
            Email_txtbx.Name = "Email_txtbx";
            Email_txtbx.Size = new Size(250, 27);
            Email_txtbx.TabIndex = 4;
            // 
            // Password_txtbx
            // 
            Password_txtbx.Anchor = AnchorStyles.None;
            Password_txtbx.BackColor = Color.White;
            Password_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Password_txtbx.Location = new Point(172, 86);
            Password_txtbx.Name = "Password_txtbx";
            Password_txtbx.PasswordChar = '*';
            Password_txtbx.Size = new Size(250, 27);
            Password_txtbx.TabIndex = 6;
            // 
            // LogInRegistration_pnl
            // 
            LogInRegistration_pnl.ColumnCount = 1;
            LogInRegistration_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LogInRegistration_pnl.Controls.Add(Register_btn, 0, 2);
            LogInRegistration_pnl.Controls.Add(LogIn_btn, 0, 0);
            LogInRegistration_pnl.Location = new Point(335, 307);
            LogInRegistration_pnl.Name = "LogInRegistration_pnl";
            LogInRegistration_pnl.RowCount = 3;
            LogInRegistration_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            LogInRegistration_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LogInRegistration_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            LogInRegistration_pnl.Size = new Size(250, 125);
            LogInRegistration_pnl.TabIndex = 1;
            // 
            // Register_btn
            // 
            Register_btn.Dock = DockStyle.Fill;
            Register_btn.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Register_btn.Location = new Point(3, 78);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(244, 44);
            Register_btn.TabIndex = 3;
            Register_btn.Text = "Регистрация";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // LogIn_btn
            // 
            LogIn_btn.Dock = DockStyle.Fill;
            LogIn_btn.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogIn_btn.Location = new Point(3, 3);
            LogIn_btn.Name = "LogIn_btn";
            LogIn_btn.Size = new Size(244, 44);
            LogIn_btn.TabIndex = 2;
            LogIn_btn.Text = "Вход";
            LogIn_btn.UseVisualStyleBackColor = true;
            LogIn_btn.Click += LogIn_btn_Click;
            // 
            // Header_lbl
            // 
            Header_lbl.AutoSize = true;
            Header_lbl.BackColor = Color.Transparent;
            Header_lbl.Font = new Font("Lucida Sans Unicode", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Header_lbl.ForeColor = SystemColors.ControlText;
            Header_lbl.Location = new Point(372, 228);
            Header_lbl.Name = "Header_lbl";
            Header_lbl.Size = new Size(175, 54);
            Header_lbl.TabIndex = 0;
            Header_lbl.Text = "MonoX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1902, 1033);
            Controls.Add(Authorization_pnl);
            Name = "Form1";
            Text = "MonoX";
            Authorization_pnl.ResumeLayout(false);
            Authorization_pnl.PerformLayout();
            LogIn_pnl.ResumeLayout(false);
            LogIn_pnl.PerformLayout();
            LogInRegistration_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Authorization_pnl;
        private Label Header_lbl;
        private TableLayoutPanel LogInRegistration_pnl;
        private Button LogIn_btn;
        private Button Register_btn;
        private TableLayoutPanel LogIn_pnl;
        private Label Email_lbl;
        private Label Password_lbl;
        private TextBox Email_txtbx;
        private MaskedTextBox Password_txtbx;
    }
}
