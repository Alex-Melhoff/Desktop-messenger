namespace MonoX
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            Background_pnl = new TableLayoutPanel();
            ChatWindow_pnl = new TableLayoutPanel();
            AddMessage_pnl = new TableLayoutPanel();
            AddMessage_rtxtbx = new RichTextBox();
            SendIcon_pctbx = new PictureBox();
            AddFileIcon_pctbx = new PictureBox();
            RightBackground_pnl = new Panel();
            LeftBackground_pnl = new Panel();
            ChatHead_pnl = new TableLayoutPanel();
            Username_lbl = new Label();
            OtherUserAccountIcon_pctbx = new PictureBox();
            OnlineStatus_lbl = new Label();
            ChatMenu_pnl = new TableLayoutPanel();
            ThisUserAccountIcon_pctbx = new PictureBox();
            SearchIcon_pctbx = new PictureBox();
            AddUserIcon_pctbx = new PictureBox();
            AddGroupIcon_pctbx = new PictureBox();
            ChatsList_pnl = new Panel();
            Background_pnl.SuspendLayout();
            ChatWindow_pnl.SuspendLayout();
            AddMessage_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SendIcon_pctbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddFileIcon_pctbx).BeginInit();
            ChatHead_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OtherUserAccountIcon_pctbx).BeginInit();
            ChatMenu_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ThisUserAccountIcon_pctbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchIcon_pctbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUserIcon_pctbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddGroupIcon_pctbx).BeginInit();
            SuspendLayout();
            // 
            // Background_pnl
            // 
            Background_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background_pnl.BackColor = Color.Gray;
            Background_pnl.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Background_pnl.ColumnCount = 4;
            Background_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Background_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            Background_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Background_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Background_pnl.Controls.Add(ChatWindow_pnl, 2, 1);
            Background_pnl.Controls.Add(RightBackground_pnl, 3, 0);
            Background_pnl.Controls.Add(LeftBackground_pnl, 0, 0);
            Background_pnl.Controls.Add(ChatHead_pnl, 2, 0);
            Background_pnl.Controls.Add(ChatMenu_pnl, 1, 0);
            Background_pnl.Controls.Add(ChatsList_pnl, 1, 1);
            Background_pnl.Location = new Point(0, 0);
            Background_pnl.Margin = new Padding(0);
            Background_pnl.MaximumSize = new Size(1920, 997);
            Background_pnl.MinimumSize = new Size(1080, 720);
            Background_pnl.Name = "Background_pnl";
            Background_pnl.RowCount = 2;
            Background_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Background_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            Background_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Background_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Background_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Background_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Background_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Background_pnl.Size = new Size(1920, 955);
            Background_pnl.TabIndex = 0;
            // 
            // ChatWindow_pnl
            // 
            ChatWindow_pnl.AutoScroll = true;
            ChatWindow_pnl.AutoSize = true;
            ChatWindow_pnl.BackColor = Color.DarkGray;
            ChatWindow_pnl.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ChatWindow_pnl.ColumnCount = 1;
            ChatWindow_pnl.ColumnStyles.Add(new ColumnStyle());
            ChatWindow_pnl.Controls.Add(AddMessage_pnl, 0, 0);
            ChatWindow_pnl.Dock = DockStyle.Fill;
            ChatWindow_pnl.Location = new Point(768, 97);
            ChatWindow_pnl.Margin = new Padding(0);
            ChatWindow_pnl.Name = "ChatWindow_pnl";
            ChatWindow_pnl.RowCount = 1;
            ChatWindow_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ChatWindow_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ChatWindow_pnl.Size = new Size(957, 857);
            ChatWindow_pnl.TabIndex = 1;
            // 
            // AddMessage_pnl
            // 
            AddMessage_pnl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddMessage_pnl.AutoSize = true;
            AddMessage_pnl.BackColor = Color.White;
            AddMessage_pnl.ColumnCount = 3;
            AddMessage_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AddMessage_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            AddMessage_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            AddMessage_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            AddMessage_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            AddMessage_pnl.Controls.Add(AddMessage_rtxtbx, 0, 0);
            AddMessage_pnl.Controls.Add(SendIcon_pctbx, 1, 0);
            AddMessage_pnl.Controls.Add(AddFileIcon_pctbx, 2, 0);
            AddMessage_pnl.Location = new Point(1, 806);
            AddMessage_pnl.Margin = new Padding(0);
            AddMessage_pnl.MaximumSize = new Size(955, 50);
            AddMessage_pnl.MinimumSize = new Size(500, 50);
            AddMessage_pnl.Name = "AddMessage_pnl";
            AddMessage_pnl.RowCount = 1;
            AddMessage_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            AddMessage_pnl.Size = new Size(955, 50);
            AddMessage_pnl.TabIndex = 0;
            // 
            // AddMessage_rtxtbx
            // 
            AddMessage_rtxtbx.BackColor = Color.White;
            AddMessage_rtxtbx.BorderStyle = BorderStyle.FixedSingle;
            AddMessage_rtxtbx.Dock = DockStyle.Fill;
            AddMessage_rtxtbx.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddMessage_rtxtbx.Location = new Point(0, 0);
            AddMessage_rtxtbx.Margin = new Padding(0);
            AddMessage_rtxtbx.Name = "AddMessage_rtxtbx";
            AddMessage_rtxtbx.Size = new Size(835, 50);
            AddMessage_rtxtbx.TabIndex = 1;
            AddMessage_rtxtbx.Text = "";
            // 
            // SendIcon_pctbx
            // 
            SendIcon_pctbx.BackColor = Color.Transparent;
            SendIcon_pctbx.BackgroundImage = (Image)resources.GetObject("SendIcon_pctbx.BackgroundImage");
            SendIcon_pctbx.BackgroundImageLayout = ImageLayout.Zoom;
            SendIcon_pctbx.BorderStyle = BorderStyle.FixedSingle;
            SendIcon_pctbx.Dock = DockStyle.Fill;
            SendIcon_pctbx.Location = new Point(835, 0);
            SendIcon_pctbx.Margin = new Padding(0);
            SendIcon_pctbx.Name = "SendIcon_pctbx";
            SendIcon_pctbx.Padding = new Padding(5);
            SendIcon_pctbx.Size = new Size(60, 50);
            SendIcon_pctbx.TabIndex = 0;
            SendIcon_pctbx.TabStop = false;
            // 
            // AddFileIcon_pctbx
            // 
            AddFileIcon_pctbx.BackColor = Color.Transparent;
            AddFileIcon_pctbx.BackgroundImage = (Image)resources.GetObject("AddFileIcon_pctbx.BackgroundImage");
            AddFileIcon_pctbx.BackgroundImageLayout = ImageLayout.Zoom;
            AddFileIcon_pctbx.BorderStyle = BorderStyle.FixedSingle;
            AddFileIcon_pctbx.Dock = DockStyle.Fill;
            AddFileIcon_pctbx.Location = new Point(895, 0);
            AddFileIcon_pctbx.Margin = new Padding(0);
            AddFileIcon_pctbx.Name = "AddFileIcon_pctbx";
            AddFileIcon_pctbx.Padding = new Padding(5);
            AddFileIcon_pctbx.Size = new Size(60, 50);
            AddFileIcon_pctbx.TabIndex = 1;
            AddFileIcon_pctbx.TabStop = false;
            // 
            // RightBackground_pnl
            // 
            RightBackground_pnl.Dock = DockStyle.Fill;
            RightBackground_pnl.Location = new Point(1726, 1);
            RightBackground_pnl.Margin = new Padding(0);
            RightBackground_pnl.Name = "RightBackground_pnl";
            Background_pnl.SetRowSpan(RightBackground_pnl, 2);
            RightBackground_pnl.Size = new Size(193, 953);
            RightBackground_pnl.TabIndex = 0;
            // 
            // LeftBackground_pnl
            // 
            LeftBackground_pnl.Location = new Point(1, 1);
            LeftBackground_pnl.Margin = new Padding(0);
            LeftBackground_pnl.Name = "LeftBackground_pnl";
            Background_pnl.SetRowSpan(LeftBackground_pnl, 2);
            LeftBackground_pnl.Size = new Size(191, 953);
            LeftBackground_pnl.TabIndex = 3;
            // 
            // ChatHead_pnl
            // 
            ChatHead_pnl.BackColor = Color.WhiteSmoke;
            ChatHead_pnl.ColumnCount = 4;
            ChatHead_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            ChatHead_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ChatHead_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            ChatHead_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            ChatHead_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ChatHead_pnl.Controls.Add(Username_lbl, 3, 1);
            ChatHead_pnl.Controls.Add(OtherUserAccountIcon_pctbx, 1, 1);
            ChatHead_pnl.Controls.Add(OnlineStatus_lbl, 3, 2);
            ChatHead_pnl.Dock = DockStyle.Fill;
            ChatHead_pnl.Location = new Point(768, 1);
            ChatHead_pnl.Margin = new Padding(0);
            ChatHead_pnl.Name = "ChatHead_pnl";
            ChatHead_pnl.RowCount = 4;
            ChatHead_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ChatHead_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ChatHead_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            ChatHead_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ChatHead_pnl.Size = new Size(957, 95);
            ChatHead_pnl.TabIndex = 0;
            // 
            // Username_lbl
            // 
            Username_lbl.Anchor = AnchorStyles.Left;
            Username_lbl.AutoSize = true;
            Username_lbl.BackColor = Color.Transparent;
            Username_lbl.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Username_lbl.Location = new Point(192, 21);
            Username_lbl.Name = "Username_lbl";
            Username_lbl.Size = new Size(461, 23);
            Username_lbl.TabIndex = 1;
            Username_lbl.Text = "Name LastName Name LastName Name LastName";
            // 
            // OtherUserAccountIcon_pctbx
            // 
            OtherUserAccountIcon_pctbx.BackColor = Color.RosyBrown;
            OtherUserAccountIcon_pctbx.BorderStyle = BorderStyle.FixedSingle;
            OtherUserAccountIcon_pctbx.Dock = DockStyle.Fill;
            OtherUserAccountIcon_pctbx.Location = new Point(28, 9);
            OtherUserAccountIcon_pctbx.Margin = new Padding(0);
            OtherUserAccountIcon_pctbx.Name = "OtherUserAccountIcon_pctbx";
            ChatHead_pnl.SetRowSpan(OtherUserAccountIcon_pctbx, 2);
            OtherUserAccountIcon_pctbx.Size = new Size(95, 75);
            OtherUserAccountIcon_pctbx.TabIndex = 0;
            OtherUserAccountIcon_pctbx.TabStop = false;
            // 
            // OnlineStatus_lbl
            // 
            OnlineStatus_lbl.Anchor = AnchorStyles.Left;
            OnlineStatus_lbl.AutoSize = true;
            OnlineStatus_lbl.BackColor = Color.Transparent;
            OnlineStatus_lbl.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OnlineStatus_lbl.Location = new Point(192, 60);
            OnlineStatus_lbl.Name = "OnlineStatus_lbl";
            OnlineStatus_lbl.Size = new Size(63, 20);
            OnlineStatus_lbl.TabIndex = 2;
            OnlineStatus_lbl.Text = "Online";
            // 
            // ChatMenu_pnl
            // 
            ChatMenu_pnl.BackColor = Color.WhiteSmoke;
            ChatMenu_pnl.BackgroundImageLayout = ImageLayout.Zoom;
            ChatMenu_pnl.ColumnCount = 9;
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.75F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.75F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.75F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.75F));
            ChatMenu_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ChatMenu_pnl.Controls.Add(ThisUserAccountIcon_pctbx, 1, 1);
            ChatMenu_pnl.Controls.Add(SearchIcon_pctbx, 3, 1);
            ChatMenu_pnl.Controls.Add(AddUserIcon_pctbx, 5, 1);
            ChatMenu_pnl.Controls.Add(AddGroupIcon_pctbx, 7, 1);
            ChatMenu_pnl.Dock = DockStyle.Fill;
            ChatMenu_pnl.Location = new Point(193, 1);
            ChatMenu_pnl.Margin = new Padding(0);
            ChatMenu_pnl.Name = "ChatMenu_pnl";
            ChatMenu_pnl.RowCount = 3;
            ChatMenu_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ChatMenu_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            ChatMenu_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ChatMenu_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ChatMenu_pnl.Size = new Size(574, 95);
            ChatMenu_pnl.TabIndex = 0;
            // 
            // ThisUserAccountIcon_pctbx
            // 
            ThisUserAccountIcon_pctbx.BackColor = Color.Transparent;
            ThisUserAccountIcon_pctbx.BackgroundImage = (Image)resources.GetObject("ThisUserAccountIcon_pctbx.BackgroundImage");
            ThisUserAccountIcon_pctbx.BackgroundImageLayout = ImageLayout.Zoom;
            ThisUserAccountIcon_pctbx.Dock = DockStyle.Fill;
            ThisUserAccountIcon_pctbx.ErrorImage = null;
            ThisUserAccountIcon_pctbx.InitialImage = (Image)resources.GetObject("ThisUserAccountIcon_pctbx.InitialImage");
            ThisUserAccountIcon_pctbx.Location = new Point(57, 19);
            ThisUserAccountIcon_pctbx.Margin = new Padding(0);
            ThisUserAccountIcon_pctbx.Name = "ThisUserAccountIcon_pctbx";
            ThisUserAccountIcon_pctbx.Size = new Size(84, 57);
            ThisUserAccountIcon_pctbx.SizeMode = PictureBoxSizeMode.Zoom;
            ThisUserAccountIcon_pctbx.TabIndex = 0;
            ThisUserAccountIcon_pctbx.TabStop = false;
            // 
            // SearchIcon_pctbx
            // 
            SearchIcon_pctbx.BackColor = Color.Transparent;
            SearchIcon_pctbx.BackgroundImage = (Image)resources.GetObject("SearchIcon_pctbx.BackgroundImage");
            SearchIcon_pctbx.BackgroundImageLayout = ImageLayout.Zoom;
            SearchIcon_pctbx.Location = new Point(181, 19);
            SearchIcon_pctbx.Margin = new Padding(0);
            SearchIcon_pctbx.Name = "SearchIcon_pctbx";
            SearchIcon_pctbx.Size = new Size(84, 57);
            SearchIcon_pctbx.SizeMode = PictureBoxSizeMode.Zoom;
            SearchIcon_pctbx.TabIndex = 1;
            SearchIcon_pctbx.TabStop = false;
            // 
            // AddUserIcon_pctbx
            // 
            AddUserIcon_pctbx.BackColor = Color.Transparent;
            AddUserIcon_pctbx.BackgroundImage = (Image)resources.GetObject("AddUserIcon_pctbx.BackgroundImage");
            AddUserIcon_pctbx.BackgroundImageLayout = ImageLayout.Zoom;
            AddUserIcon_pctbx.Location = new Point(305, 19);
            AddUserIcon_pctbx.Margin = new Padding(0);
            AddUserIcon_pctbx.Name = "AddUserIcon_pctbx";
            AddUserIcon_pctbx.Size = new Size(84, 57);
            AddUserIcon_pctbx.SizeMode = PictureBoxSizeMode.Zoom;
            AddUserIcon_pctbx.TabIndex = 2;
            AddUserIcon_pctbx.TabStop = false;
            // 
            // AddGroupIcon_pctbx
            // 
            AddGroupIcon_pctbx.BackColor = Color.Transparent;
            AddGroupIcon_pctbx.BackgroundImage = (Image)resources.GetObject("AddGroupIcon_pctbx.BackgroundImage");
            AddGroupIcon_pctbx.BackgroundImageLayout = ImageLayout.Zoom;
            AddGroupIcon_pctbx.Location = new Point(429, 19);
            AddGroupIcon_pctbx.Margin = new Padding(0);
            AddGroupIcon_pctbx.Name = "AddGroupIcon_pctbx";
            AddGroupIcon_pctbx.Size = new Size(84, 57);
            AddGroupIcon_pctbx.SizeMode = PictureBoxSizeMode.Zoom;
            AddGroupIcon_pctbx.TabIndex = 3;
            AddGroupIcon_pctbx.TabStop = false;
            // 
            // ChatsList_pnl
            // 
            ChatsList_pnl.AutoScroll = true;
            ChatsList_pnl.BackColor = Color.Gainsboro;
            ChatsList_pnl.Dock = DockStyle.Fill;
            ChatsList_pnl.Location = new Point(193, 97);
            ChatsList_pnl.Margin = new Padding(0);
            ChatsList_pnl.Name = "ChatsList_pnl";
            ChatsList_pnl.Size = new Size(574, 857);
            ChatsList_pnl.TabIndex = 2;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 953);
            Controls.Add(Background_pnl);
            MaximumSize = new Size(1920, 1030);
            MinimumSize = new Size(1080, 720);
            Name = "ChatForm";
            Text = "MonoX";
            Background_pnl.ResumeLayout(false);
            Background_pnl.PerformLayout();
            ChatWindow_pnl.ResumeLayout(false);
            ChatWindow_pnl.PerformLayout();
            AddMessage_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SendIcon_pctbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddFileIcon_pctbx).EndInit();
            ChatHead_pnl.ResumeLayout(false);
            ChatHead_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OtherUserAccountIcon_pctbx).EndInit();
            ChatMenu_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ThisUserAccountIcon_pctbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchIcon_pctbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUserIcon_pctbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddGroupIcon_pctbx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Background_pnl;
        private TableLayoutPanel ChatMenu_pnl;
        private TableLayoutPanel ChatHead_pnl;
        private TableLayoutPanel ChatWindow_pnl;
        private Panel ChatsList_pnl;
        private PictureBox ThisUserAccountIcon_pctbx;
        private PictureBox SearchIcon_pctbx;
        private PictureBox AddUserIcon_pctbx;
        private PictureBox AddGroupIcon_pctbx;
        private Panel LeftBackground_pnl;
        private Panel RightBackground_pnl;
        private TableLayoutPanel AddMessage_pnl;
        private PictureBox SendIcon_pctbx;
        private PictureBox AddFileIcon_pctbx;
        private RichTextBox AddMessage_rtxtbx;
        private PictureBox OtherUserAccountIcon_pctbx;
        private Label Username_lbl;
        private Label OnlineStatus_lbl;
    }
}