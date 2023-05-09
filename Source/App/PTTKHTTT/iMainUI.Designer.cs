namespace PTTKHTTT
{
    partial class iMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iMainUI));
            label2 = new Label();
            panelTitleBar = new Panel();
            panel1 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            dangXuat_Btn = new Button();
            pictureBox1 = new PictureBox();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelMenu = new Panel();
            infoRoom_Btn = new Button();
            bill_Btn = new Button();
            dichVu_Btn = new Button();
            datPhong_Btn = new Button();
            hoSo_Btn = new Button();
            panelLogo = new Panel();
            lblTeam = new Label();
            panelDesktopPane = new Panel();
            panel_Logo = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 43);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 2;
            label2.Text = "Xin chào, Bùn Ngủ";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1062, 113);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(dangXuat_Btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(762, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 113);
            panel1.TabIndex = 10;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.Lime;
            btnMinimize.Location = new Point(176, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 40);
            btnMinimize.TabIndex = 11;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.Yellow;
            btnMaximize.Location = new Point(222, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 40);
            btnMaximize.TabIndex = 10;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(260, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 9;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dangXuat_Btn
            // 
            dangXuat_Btn.Anchor = AnchorStyles.None;
            dangXuat_Btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dangXuat_Btn.Image = Properties.Resources.logout1;
            dangXuat_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            dangXuat_Btn.Location = new Point(53, 72);
            dangXuat_Btn.Name = "dangXuat_Btn";
            dangXuat_Btn.Size = new Size(143, 40);
            dangXuat_Btn.TabIndex = 8;
            dangXuat_Btn.Text = "Đăng xuất";
            dangXuat_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dangXuat_Btn.UseVisualStyleBackColor = true;
            dangXuat_Btn.Click += dangXuat_Btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(222, 43);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 69);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = Properties.Resources.close;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(113, 113);
            btnCloseChildForm.TabIndex = 9;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(146, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(218, 46);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "TRANG CHỦ";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(infoRoom_Btn);
            panelMenu.Controls.Add(bill_Btn);
            panelMenu.Controls.Add(dichVu_Btn);
            panelMenu.Controls.Add(datPhong_Btn);
            panelMenu.Controls.Add(hoSo_Btn);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 673);
            panelMenu.TabIndex = 2;
            // 
            // infoRoom_Btn
            // 
            infoRoom_Btn.Dock = DockStyle.Top;
            infoRoom_Btn.FlatAppearance.BorderSize = 0;
            infoRoom_Btn.FlatStyle = FlatStyle.Flat;
            infoRoom_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoRoom_Btn.ForeColor = Color.Gainsboro;
            infoRoom_Btn.Image = Properties.Resources.beds;
            infoRoom_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            infoRoom_Btn.Location = new Point(0, 553);
            infoRoom_Btn.Margin = new Padding(3, 4, 3, 4);
            infoRoom_Btn.Name = "infoRoom_Btn";
            infoRoom_Btn.Size = new Size(200, 110);
            infoRoom_Btn.TabIndex = 4;
            infoRoom_Btn.Text = "Thông tin đặt phòng";
            infoRoom_Btn.TextAlign = ContentAlignment.MiddleLeft;
            infoRoom_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            infoRoom_Btn.UseVisualStyleBackColor = true;
            infoRoom_Btn.Click += infoRoom_Btn_Click;
            // 
            // bill_Btn
            // 
            bill_Btn.Dock = DockStyle.Top;
            bill_Btn.FlatAppearance.BorderSize = 0;
            bill_Btn.FlatStyle = FlatStyle.Flat;
            bill_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bill_Btn.ForeColor = Color.Gainsboro;
            bill_Btn.Image = Properties.Resources.bill;
            bill_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            bill_Btn.Location = new Point(0, 443);
            bill_Btn.Margin = new Padding(3, 4, 3, 4);
            bill_Btn.Name = "bill_Btn";
            bill_Btn.Size = new Size(200, 110);
            bill_Btn.TabIndex = 2;
            bill_Btn.Text = "Thanh Toán";
            bill_Btn.TextAlign = ContentAlignment.MiddleLeft;
            bill_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            bill_Btn.UseVisualStyleBackColor = true;
            bill_Btn.Click += bill_Btn_Click;
            // 
            // dichVu_Btn
            // 
            dichVu_Btn.Dock = DockStyle.Top;
            dichVu_Btn.FlatAppearance.BorderSize = 0;
            dichVu_Btn.FlatStyle = FlatStyle.Flat;
            dichVu_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dichVu_Btn.ForeColor = Color.Gainsboro;
            dichVu_Btn.Image = Properties.Resources.room_service;
            dichVu_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            dichVu_Btn.Location = new Point(0, 333);
            dichVu_Btn.Margin = new Padding(3, 4, 3, 4);
            dichVu_Btn.Name = "dichVu_Btn";
            dichVu_Btn.Size = new Size(200, 110);
            dichVu_Btn.TabIndex = 3;
            dichVu_Btn.Text = "Các dịch vụ ";
            dichVu_Btn.TextAlign = ContentAlignment.MiddleLeft;
            dichVu_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dichVu_Btn.UseVisualStyleBackColor = true;
            dichVu_Btn.Click += dichVu_Btn_Click;
            // 
            // datPhong_Btn
            // 
            datPhong_Btn.Dock = DockStyle.Top;
            datPhong_Btn.FlatAppearance.BorderSize = 0;
            datPhong_Btn.FlatStyle = FlatStyle.Flat;
            datPhong_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            datPhong_Btn.ForeColor = Color.Gainsboro;
            datPhong_Btn.Image = Properties.Resources.booking;
            datPhong_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            datPhong_Btn.Location = new Point(0, 223);
            datPhong_Btn.Margin = new Padding(3, 4, 3, 4);
            datPhong_Btn.Name = "datPhong_Btn";
            datPhong_Btn.Size = new Size(200, 110);
            datPhong_Btn.TabIndex = 1;
            datPhong_Btn.Text = "Đặt phòng";
            datPhong_Btn.TextAlign = ContentAlignment.MiddleLeft;
            datPhong_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            datPhong_Btn.UseVisualStyleBackColor = true;
            datPhong_Btn.Click += datPhong_Btn_Click;
            // 
            // hoSo_Btn
            // 
            hoSo_Btn.Dock = DockStyle.Top;
            hoSo_Btn.FlatAppearance.BorderSize = 0;
            hoSo_Btn.FlatStyle = FlatStyle.Flat;
            hoSo_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hoSo_Btn.ForeColor = Color.Gainsboro;
            hoSo_Btn.Image = Properties.Resources.profile_icon;
            hoSo_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            hoSo_Btn.Location = new Point(0, 113);
            hoSo_Btn.Margin = new Padding(3, 4, 3, 4);
            hoSo_Btn.Name = "hoSo_Btn";
            hoSo_Btn.Size = new Size(200, 110);
            hoSo_Btn.TabIndex = 0;
            hoSo_Btn.Text = "Hồ sơ";
            hoSo_Btn.TextAlign = ContentAlignment.MiddleLeft;
            hoSo_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            hoSo_Btn.UseVisualStyleBackColor = true;
            hoSo_Btn.Click += hoSo_Btn_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblTeam);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 113);
            panelLogo.TabIndex = 5;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTeam.ForeColor = Color.White;
            lblTeam.ImageAlign = ContentAlignment.MiddleLeft;
            lblTeam.Location = new Point(12, 39);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(173, 28);
            lblTeam.TabIndex = 0;
            lblTeam.Text = "TEAM 1: SLEEPING";
            lblTeam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Anchor = AnchorStyles.None;
            panelDesktopPane.Controls.Add(panel_Logo);
            panelDesktopPane.Location = new Point(200, 113);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1062, 560);
            panelDesktopPane.TabIndex = 3;
            panelDesktopPane.Paint += panel1_Paint;
            // 
            // panel_Logo
            // 
            panel_Logo.Anchor = AnchorStyles.None;
            panel_Logo.Controls.Add(pictureBox2);
            panel_Logo.Controls.Add(label3);
            panel_Logo.Location = new Point(285, 188);
            panel_Logo.Name = "panel_Logo";
            panel_Logo.Size = new Size(559, 142);
            panel_Logo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(134, 38);
            label3.Name = "label3";
            label3.Size = new Size(436, 67);
            label3.TabIndex = 1;
            label3.Text = "TEAM 1: SLEEPING";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1280, 720);
            Name = "iMainUI";
            Text = "TRANG CHỦ";
            Load += iMainUI_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panel_Logo.ResumeLayout(false);
            panel_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panelTitleBar;
        private PictureBox pictureBox1;
        private Panel panelMenu;
        private Button hoSo_Btn;
        private Button dichVu_Btn;
        private Button bill_Btn;
        private Button datPhong_Btn;
        private Button infoRoom_Btn;
        private Panel panelLogo;
        private Label lblTitle;
        private Label lblTeam;
        private Button dangXuat_Btn;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Panel panel1;
        private Panel panel_Logo;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
    }
}