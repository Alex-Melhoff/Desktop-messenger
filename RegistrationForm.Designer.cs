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
            Register_pnl = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Nickname_lbl = new Label();
            Email_lbl = new Label();
            Password_lbl = new Label();
            Nickname_txtbx = new TextBox();
            Email_txtbx = new TextBox();
            Password_txtbx = new MaskedTextBox();
            Register_Header_lbl = new Label();
            Register_pnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Register_pnl
            // 
            Register_pnl.BackColor = Color.WhiteSmoke;
            Register_pnl.Controls.Add(Register_Header_lbl);
            Register_pnl.Controls.Add(tableLayoutPanel1);
            Register_pnl.Location = new Point(500, 0);
            Register_pnl.Name = "Register_pnl";
            Register_pnl.Size = new Size(920, 1080);
            Register_pnl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(Nickname_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(Email_lbl, 0, 2);
            tableLayoutPanel1.Controls.Add(Password_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(Nickname_txtbx, 2, 0);
            tableLayoutPanel1.Controls.Add(Email_txtbx, 2, 2);
            tableLayoutPanel1.Controls.Add(Password_txtbx, 2, 4);
            tableLayoutPanel1.Location = new Point(243, 337);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(425, 200);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Nickname_lbl
            // 
            Nickname_lbl.Anchor = AnchorStyles.Left;
            Nickname_lbl.AutoSize = true;
            Nickname_lbl.BackColor = Color.Transparent;
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
            Email_lbl.Location = new Point(3, 86);
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
            Password_lbl.Location = new Point(3, 161);
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
            Nickname_txtbx.Location = new Point(172, 11);
            Nickname_txtbx.Name = "Nickname_txtbx";
            Nickname_txtbx.Size = new Size(250, 27);
            Nickname_txtbx.TabIndex = 8;
            // 
            // Email_txtbx
            // 
            Email_txtbx.Anchor = AnchorStyles.None;
            Email_txtbx.BackColor = Color.White;
            Email_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Email_txtbx.Location = new Point(172, 86);
            Email_txtbx.Name = "Email_txtbx";
            Email_txtbx.Size = new Size(250, 27);
            Email_txtbx.TabIndex = 9;
            // 
            // Password_txtbx
            // 
            Password_txtbx.Anchor = AnchorStyles.None;
            Password_txtbx.BackColor = Color.White;
            Password_txtbx.BorderStyle = BorderStyle.FixedSingle;
            Password_txtbx.Location = new Point(172, 161);
            Password_txtbx.Name = "Password_txtbx";
            Password_txtbx.PasswordChar = '*';
            Password_txtbx.Size = new Size(250, 27);
            Password_txtbx.TabIndex = 10;
            // 
            // Register_Header_lbl
            // 
            Register_Header_lbl.AutoSize = true;
            Register_Header_lbl.BackColor = Color.Transparent;
            Register_Header_lbl.Font = new Font("Lucida Sans Unicode", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Register_Header_lbl.ForeColor = SystemColors.ControlText;
            Register_Header_lbl.Location = new Point(305, 245);
            Register_Header_lbl.Name = "Register_Header_lbl";
            Register_Header_lbl.Size = new Size(298, 54);
            Register_Header_lbl.TabIndex = 1;
            Register_Header_lbl.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1902, 1033);
            Controls.Add(Register_pnl);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Register_pnl.ResumeLayout(false);
            Register_pnl.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Register_pnl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Nickname_lbl;
        private Label Email_lbl;
        private Label Password_lbl;
        private TextBox Nickname_txtbx;
        private TextBox Email_txtbx;
        private MaskedTextBox Password_txtbx;
        private Label Register_Header_lbl;
    }
}