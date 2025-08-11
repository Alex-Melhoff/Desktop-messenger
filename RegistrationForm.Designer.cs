namespace MonoX
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Register_btn = new Button();
            LogIn_btn = new Button();
            Register_Header_lbl = new Label();
            RegisterForm_pnl = new TableLayoutPanel();
            Register_pnl = new TableLayoutPanel();
            Fields_pnl = new TableLayoutPanel();
            Nickname_lbl = new Label();
            Email_lbl = new Label();
            Password_lbl = new Label();
            Nickname_txtbx = new TextBox();
            Email_txtbx = new TextBox();
            Password_txtbx = new MaskedTextBox();
            RegisterForm_pnl.SuspendLayout();
            Register_pnl.SuspendLayout();
            Fields_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // Register_btn
            // 
            Register_btn.BackColor = Color.LightGray;
            Register_pnl.SetColumnSpan(Register_btn, 3);
            Register_btn.Dock = DockStyle.Fill;
            Register_btn.FlatAppearance.BorderSize = 0;
            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Register_btn.Location = new Point(307, 551);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(289, 38);
            Register_btn.TabIndex = 4;
            Register_btn.TabStop = false;
            Register_btn.Text = "Зарегистрироваться";
            Register_btn.UseVisualStyleBackColor = false;
            Register_btn.Click += Register_btn_Click;
            // 
            // LogIn_btn
            // 
            LogIn_btn.BackColor = Color.LightGray;
            Register_pnl.SetColumnSpan(LogIn_btn, 3);
            LogIn_btn.Dock = DockStyle.Fill;
            LogIn_btn.FlatAppearance.BorderSize = 0;
            LogIn_btn.FlatStyle = FlatStyle.Flat;
            LogIn_btn.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogIn_btn.Location = new Point(307, 613);
            LogIn_btn.Name = "LogIn_btn";
            LogIn_btn.Size = new Size(289, 38);
            LogIn_btn.TabIndex = 3;
            LogIn_btn.TabStop = false;
            LogIn_btn.Text = "Войти";
            LogIn_btn.UseVisualStyleBackColor = false;
            LogIn_btn.Visible = false;
            LogIn_btn.Click += LogIn_btn_Click;
            // 
            // Register_Header_lbl
            // 
            Register_Header_lbl.Anchor = AnchorStyles.None;
            Register_Header_lbl.AutoSize = true;
            Register_Header_lbl.BackColor = Color.Transparent;
            Register_pnl.SetColumnSpan(Register_Header_lbl, 5);
            Register_Header_lbl.Font = new Font("Lucida Sans Unicode", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Register_Header_lbl.ForeColor = SystemColors.ControlText;
            Register_Header_lbl.Location = new Point(302, 236);
            Register_Header_lbl.Name = "Register_Header_lbl";
            Register_Header_lbl.Size = new Size(298, 53);
            Register_Header_lbl.TabIndex = 1;
            Register_Header_lbl.Text = "Регистрация";
            Register_Header_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm_pnl
            // 
            RegisterForm_pnl.BackColor = Color.Gray;
            RegisterForm_pnl.ColumnCount = 3;
            RegisterForm_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            RegisterForm_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            RegisterForm_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            RegisterForm_pnl.Controls.Add(Register_pnl, 1, 0);
            RegisterForm_pnl.Dock = DockStyle.Fill;
            RegisterForm_pnl.Location = new Point(0, 0);
            RegisterForm_pnl.Name = "RegisterForm_pnl";
            RegisterForm_pnl.RowCount = 1;
            RegisterForm_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RegisterForm_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RegisterForm_pnl.Size = new Size(1902, 1033);
            RegisterForm_pnl.TabIndex = 1;
            // 
            // Register_pnl
            // 
            Register_pnl.BackColor = Color.WhiteSmoke;
            Register_pnl.ColumnCount = 7;
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.1F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.4F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.1F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7F));
            Register_pnl.Controls.Add(LogIn_btn, 2, 7);
            Register_pnl.Controls.Add(Register_btn, 2, 5);
            Register_pnl.Controls.Add(Register_Header_lbl, 1, 1);
            Register_pnl.Controls.Add(Fields_pnl, 1, 3);
            Register_pnl.Dock = DockStyle.Fill;
            Register_pnl.Location = new Point(497, 3);
            Register_pnl.Name = "Register_pnl";
            Register_pnl.RowCount = 9;
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 5.2F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 4.4F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 1.5F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 4.3F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 1.8F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 4.3F));
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 36.1F));
            Register_pnl.Size = new Size(906, 1027);
            Register_pnl.TabIndex = 1;
            // 
            // Fields_pnl
            // 
            Fields_pnl.ColumnCount = 3;
            Register_pnl.SetColumnSpan(Fields_pnl, 5);
            Fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            Fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            Fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Fields_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Fields_pnl.Controls.Add(Nickname_lbl, 0, 0);
            Fields_pnl.Controls.Add(Email_lbl, 0, 2);
            Fields_pnl.Controls.Add(Password_lbl, 0, 4);
            Fields_pnl.Controls.Add(Nickname_txtbx, 2, 0);
            Fields_pnl.Controls.Add(Email_txtbx, 2, 2);
            Fields_pnl.Controls.Add(Password_txtbx, 2, 4);
            Fields_pnl.Location = new Point(241, 334);
            Fields_pnl.Margin = new Padding(0);
            Fields_pnl.Name = "Fields_pnl";
            Fields_pnl.RowCount = 5;
            Fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Fields_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Fields_pnl.Size = new Size(421, 199);
            Fields_pnl.TabIndex = 0;
            // 
            // Nickname_lbl
            // 
            Nickname_lbl.Anchor = AnchorStyles.Left;
            Nickname_lbl.AutoSize = true;
            Nickname_lbl.BackColor = Color.Transparent;
            Fields_pnl.SetColumnSpan(Nickname_lbl, 2);
            Nickname_lbl.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Nickname_lbl.Location = new Point(3, 11);
            Nickname_lbl.Name = "Nickname_lbl";
            Nickname_lbl.Size = new Size(103, 27);
            Nickname_lbl.TabIndex = 7;
            Nickname_lbl.Text = "Никнейм";
            Nickname_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Email_lbl
            // 
            Email_lbl.Anchor = AnchorStyles.Left;
            Email_lbl.AutoSize = true;
            Email_lbl.BackColor = Color.Transparent;
            Email_lbl.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Email_lbl.Location = new Point(3, 84);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(77, 27);
            Email_lbl.TabIndex = 5;
            Email_lbl.Text = "Email";
            Email_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Password_lbl
            // 
            Password_lbl.Anchor = AnchorStyles.Left;
            Password_lbl.AutoSize = true;
            Password_lbl.BackColor = Color.Transparent;
            Password_lbl.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_lbl.Location = new Point(3, 159);
            Password_lbl.Name = "Password_lbl";
            Password_lbl.Size = new Size(90, 27);
            Password_lbl.TabIndex = 6;
            Password_lbl.Text = "Пароль";
            Password_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Nickname_txtbx
            // 
            Nickname_txtbx.Anchor = AnchorStyles.None;
            Nickname_txtbx.BackColor = Color.White;
            Nickname_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Nickname_txtbx.Location = new Point(171, 11);
            Nickname_txtbx.Name = "Nickname_txtbx";
            Nickname_txtbx.Size = new Size(247, 27);
            Nickname_txtbx.TabIndex = 8;
            // 
            // Email_txtbx
            // 
            Email_txtbx.Anchor = AnchorStyles.None;
            Email_txtbx.BackColor = Color.White;
            Email_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Email_txtbx.Location = new Point(171, 84);
            Email_txtbx.Name = "Email_txtbx";
            Email_txtbx.Size = new Size(247, 27);
            Email_txtbx.TabIndex = 9;
            // 
            // Password_txtbx
            // 
            Password_txtbx.Anchor = AnchorStyles.None;
            Password_txtbx.BackColor = Color.White;
            Password_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Password_txtbx.Location = new Point(171, 159);
            Password_txtbx.Name = "Password_txtbx";
            Password_txtbx.PasswordChar = '*';
            Password_txtbx.Size = new Size(247, 27);
            Password_txtbx.TabIndex = 10;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1902, 1033);
            Controls.Add(RegisterForm_pnl);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1080, 720);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            RegisterForm_pnl.ResumeLayout(false);
            Register_pnl.ResumeLayout(false);
            Register_pnl.PerformLayout();
            Fields_pnl.ResumeLayout(false);
            Fields_pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Register_Header_lbl;
        private Button LogIn_btn;
        private Button Register_btn;
        private TableLayoutPanel RegisterForm_pnl;
        private TableLayoutPanel Register_pnl;
        private TableLayoutPanel Fields_pnl;
        private Label Nickname_lbl;
        private Label Email_lbl;
        private Label Password_lbl;
        private TextBox Nickname_txtbx;
        private TextBox Email_txtbx;
        private MaskedTextBox Password_txtbx;
    }
}