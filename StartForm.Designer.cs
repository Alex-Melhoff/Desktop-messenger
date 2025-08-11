namespace MonoX
{
    partial class StartForm
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            Password_txtbx = new MaskedTextBox();
            StartForm_pnl = new TableLayoutPanel();
            Authorization_pnl = new TableLayoutPanel();
            LogIn_pnl = new TableLayoutPanel();
            LogIn_Continue_btn = new Button();
            Password_lbl = new Label();
            Email_lbl = new Label();
            Email_txtbx = new TextBox();
            Header_lbl = new Label();
            LogInRegistration_pnl = new TableLayoutPanel();
            Register_btn = new Button();
            LogIn_btn = new Button();
            StartForm_pnl.SuspendLayout();
            Authorization_pnl.SuspendLayout();
            LogIn_pnl.SuspendLayout();
            LogInRegistration_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // Password_txtbx
            // 
            Password_txtbx.Anchor = AnchorStyles.None;
            Password_txtbx.BackColor = Color.White;
            Password_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Password_txtbx.Location = new Point(171, 78);
            Password_txtbx.Name = "Password_txtbx";
            Password_txtbx.PasswordChar = '*';
            Password_txtbx.Size = new Size(246, 27);
            Password_txtbx.TabIndex = 6;
            toolTip1.SetToolTip(Password_txtbx, ">8 символов, буквы, цифры и символы");
            // 
            // StartForm_pnl
            // 
            StartForm_pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartForm_pnl.BackColor = Color.Gray;
            StartForm_pnl.ColumnCount = 3;
            StartForm_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            StartForm_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            StartForm_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            StartForm_pnl.Controls.Add(Authorization_pnl, 1, 0);
            StartForm_pnl.Dock = DockStyle.Fill;
            StartForm_pnl.Location = new Point(0, 0);
            StartForm_pnl.Margin = new Padding(0);
            StartForm_pnl.Name = "StartForm_pnl";
            StartForm_pnl.RowCount = 1;
            StartForm_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            StartForm_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StartForm_pnl.Size = new Size(1902, 1033);
            StartForm_pnl.TabIndex = 4;
            // 
            // Authorization_pnl
            // 
            Authorization_pnl.BackColor = Color.WhiteSmoke;
            Authorization_pnl.ColumnCount = 7;
            Authorization_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5F));
            Authorization_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
            Authorization_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            Authorization_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            Authorization_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            Authorization_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
            Authorization_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5000019F));
            Authorization_pnl.Controls.Add(LogIn_pnl, 1, 5);
            Authorization_pnl.Controls.Add(Header_lbl, 2, 1);
            Authorization_pnl.Controls.Add(LogInRegistration_pnl, 2, 3);
            Authorization_pnl.Dock = DockStyle.Fill;
            Authorization_pnl.Location = new Point(494, 0);
            Authorization_pnl.Margin = new Padding(0);
            Authorization_pnl.Name = "Authorization_pnl";
            Authorization_pnl.RowCount = 7;
            Authorization_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            Authorization_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Authorization_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 2.4F));
            Authorization_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6F));
            Authorization_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 2.9F));
            Authorization_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5F));
            Authorization_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 38.6F));
            Authorization_pnl.Size = new Size(912, 1033);
            Authorization_pnl.TabIndex = 1;
            // 
            // LogIn_pnl
            // 
            LogIn_pnl.ColumnCount = 3;
            Authorization_pnl.SetColumnSpan(LogIn_pnl, 5);
            LogIn_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            LogIn_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            LogIn_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            LogIn_pnl.Controls.Add(LogIn_Continue_btn, 0, 4);
            LogIn_pnl.Controls.Add(Password_lbl, 0, 2);
            LogIn_pnl.Controls.Add(Email_lbl, 0, 0);
            LogIn_pnl.Controls.Add(Email_txtbx, 2, 0);
            LogIn_pnl.Controls.Add(Password_txtbx, 2, 2);
            LogIn_pnl.Dock = DockStyle.Fill;
            LogIn_pnl.Location = new Point(244, 442);
            LogIn_pnl.Name = "LogIn_pnl";
            LogIn_pnl.RowCount = 5;
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LogIn_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LogIn_pnl.Size = new Size(420, 185);
            LogIn_pnl.TabIndex = 3;
            LogIn_pnl.Visible = false;
            // 
            // LogIn_Continue_btn
            // 
            LogIn_Continue_btn.BackColor = Color.LightGray;
            LogIn_pnl.SetColumnSpan(LogIn_Continue_btn, 3);
            LogIn_Continue_btn.Dock = DockStyle.Fill;
            LogIn_Continue_btn.FlatAppearance.BorderSize = 0;
            LogIn_Continue_btn.FlatStyle = FlatStyle.Flat;
            LogIn_Continue_btn.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogIn_Continue_btn.Location = new Point(3, 141);
            LogIn_Continue_btn.Name = "LogIn_Continue_btn";
            LogIn_Continue_btn.Size = new Size(414, 41);
            LogIn_Continue_btn.TabIndex = 4;
            LogIn_Continue_btn.TabStop = false;
            LogIn_Continue_btn.Text = "Войти";
            LogIn_Continue_btn.UseVisualStyleBackColor = false;
            LogIn_Continue_btn.Click += LogIn_Continue_btn_Click;
            // 
            // Password_lbl
            // 
            Password_lbl.Anchor = AnchorStyles.Left;
            Password_lbl.AutoSize = true;
            Password_lbl.BackColor = Color.Transparent;
            Password_lbl.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_lbl.Location = new Point(3, 78);
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
            Email_lbl.Location = new Point(3, 9);
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
            Email_txtbx.Location = new Point(171, 9);
            Email_txtbx.Name = "Email_txtbx";
            Email_txtbx.Size = new Size(246, 27);
            Email_txtbx.TabIndex = 4;
            // 
            // Header_lbl
            // 
            Header_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Header_lbl.AutoSize = true;
            Header_lbl.BackColor = Color.Transparent;
            Authorization_pnl.SetColumnSpan(Header_lbl, 3);
            Header_lbl.Font = new Font("Lucida Sans Unicode", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Header_lbl.ForeColor = SystemColors.ControlText;
            Header_lbl.Location = new Point(330, 216);
            Header_lbl.Name = "Header_lbl";
            Header_lbl.Size = new Size(248, 51);
            Header_lbl.TabIndex = 0;
            Header_lbl.Text = "MonoX";
            Header_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogInRegistration_pnl
            // 
            LogInRegistration_pnl.ColumnCount = 1;
            Authorization_pnl.SetColumnSpan(LogInRegistration_pnl, 3);
            LogInRegistration_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LogInRegistration_pnl.Controls.Add(Register_btn, 0, 2);
            LogInRegistration_pnl.Controls.Add(LogIn_btn, 0, 0);
            LogInRegistration_pnl.Dock = DockStyle.Fill;
            LogInRegistration_pnl.Location = new Point(330, 294);
            LogInRegistration_pnl.Name = "LogInRegistration_pnl";
            LogInRegistration_pnl.RowCount = 3;
            LogInRegistration_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            LogInRegistration_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LogInRegistration_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            LogInRegistration_pnl.Size = new Size(248, 113);
            LogInRegistration_pnl.TabIndex = 1;
            // 
            // Register_btn
            // 
            Register_btn.BackColor = Color.LightGray;
            Register_btn.Dock = DockStyle.Fill;
            Register_btn.FlatAppearance.BorderSize = 0;
            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Register_btn.Location = new Point(3, 70);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(242, 40);
            Register_btn.TabIndex = 3;
            Register_btn.TabStop = false;
            Register_btn.Text = "Регистрация";
            Register_btn.UseVisualStyleBackColor = false;
            Register_btn.Click += Register_btn_Click;
            // 
            // LogIn_btn
            // 
            LogIn_btn.BackColor = Color.LightGray;
            LogIn_btn.Dock = DockStyle.Fill;
            LogIn_btn.FlatAppearance.BorderSize = 0;
            LogIn_btn.FlatStyle = FlatStyle.Flat;
            LogIn_btn.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogIn_btn.Location = new Point(3, 3);
            LogIn_btn.Name = "LogIn_btn";
            LogIn_btn.Size = new Size(242, 39);
            LogIn_btn.TabIndex = 2;
            LogIn_btn.TabStop = false;
            LogIn_btn.Text = "Вход";
            LogIn_btn.UseVisualStyleBackColor = false;
            LogIn_btn.Click += LogIn_btn_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1902, 1033);
            Controls.Add(StartForm_pnl);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1080, 720);
            Name = "StartForm";
            Text = "MonoX";
            StartForm_pnl.ResumeLayout(false);
            Authorization_pnl.ResumeLayout(false);
            Authorization_pnl.PerformLayout();
            LogIn_pnl.ResumeLayout(false);
            LogIn_pnl.PerformLayout();
            LogInRegistration_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private TableLayoutPanel StartForm_pnl;
        private TableLayoutPanel LogIn_pnl;
        private Button LogIn_Continue_btn;
        private Label Password_lbl;
        private Label Email_lbl;
        private TextBox Email_txtbx;
        private MaskedTextBox Password_txtbx;
        private TableLayoutPanel LogInRegistration_pnl;
        private Button Register_btn;
        private Button LogIn_btn;
        private Label Header_lbl;
        private TableLayoutPanel Authorization_pnl;
    }
}
