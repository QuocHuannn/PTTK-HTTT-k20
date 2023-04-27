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
            label2 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            vScrollBar2 = new VScrollBar();
            vScrollBar1 = new VScrollBar();
            panelMenu = new Panel();
            panelLogo = new Panel();
            pictureBox3 = new PictureBox();
            lblTeam = new Label();
            infoRoom_Btn = new Button();
            hoSo_Btn = new Button();
            datPhong_Btn = new Button();
            dichVu_Btn = new Button();
            bill_Btn = new Button();
            dataGridView1 = new DataGridView();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(760, 75);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 2;
            label2.Text = "Xin chào, Username";
            // 
            // panelTitleBar
            // 
            panelTitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.BorderStyle = BorderStyle.FixedSingle;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Controls.Add(pictureBox1);
            panelTitleBar.Controls.Add(pictureBox2);
            panelTitleBar.Controls.Add(vScrollBar2);
            panelTitleBar.Controls.Add(vScrollBar1);
            panelTitleBar.Controls.Add(label2);
            panelTitleBar.Location = new Point(221, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1038, 115);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(532, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(101, 38);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "HOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 26);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 6;
            label1.Text = "Đăng xuất";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(965, 43);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(199, 69);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(34, 533);
            vScrollBar2.TabIndex = 5;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(203, 69);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(9, 536);
            vScrollBar1.TabIndex = 4;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(infoRoom_Btn);
            panelMenu.Controls.Add(hoSo_Btn);
            panelMenu.Controls.Add(datPhong_Btn);
            panelMenu.Controls.Add(dichVu_Btn);
            panelMenu.Controls.Add(bill_Btn);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 673);
            panelMenu.TabIndex = 2;
            // 
            // panelLogo
            // 
            panelLogo.Anchor = AnchorStyles.None;
            panelLogo.Controls.Add(pictureBox3);
            panelLogo.Controls.Add(lblTeam);
            panelLogo.Location = new Point(0, 1);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 110);
            panelLogo.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.sleeping2;
            pictureBox3.Location = new Point(69, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTeam.ForeColor = Color.White;
            lblTeam.ImageAlign = ContentAlignment.MiddleLeft;
            lblTeam.Location = new Point(25, 8);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(173, 28);
            lblTeam.TabIndex = 0;
            lblTeam.Text = "TEAM 1: SLEEPING";
            lblTeam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // infoRoom_Btn
            // 
            infoRoom_Btn.Anchor = AnchorStyles.None;
            infoRoom_Btn.FlatStyle = FlatStyle.Flat;
            infoRoom_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoRoom_Btn.ForeColor = Color.Gainsboro;
            infoRoom_Btn.Image = Properties.Resources.beds;
            infoRoom_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            infoRoom_Btn.Location = new Point(-1, 558);
            infoRoom_Btn.Margin = new Padding(3, 4, 3, 4);
            infoRoom_Btn.Name = "infoRoom_Btn";
            infoRoom_Btn.Size = new Size(220, 110);
            infoRoom_Btn.TabIndex = 4;
            infoRoom_Btn.Text = "Thông tin đặt phòng";
            infoRoom_Btn.TextAlign = ContentAlignment.MiddleLeft;
            infoRoom_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            infoRoom_Btn.UseVisualStyleBackColor = true;
            infoRoom_Btn.Click += button3_Click;
            // 
            // hoSo_Btn
            // 
            hoSo_Btn.Anchor = AnchorStyles.None;
            hoSo_Btn.FlatStyle = FlatStyle.Flat;
            hoSo_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hoSo_Btn.ForeColor = Color.Gainsboro;
            hoSo_Btn.Image = Properties.Resources.profile_icon;
            hoSo_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            hoSo_Btn.Location = new Point(-1, 114);
            hoSo_Btn.Margin = new Padding(3, 4, 3, 4);
            hoSo_Btn.Name = "hoSo_Btn";
            hoSo_Btn.Size = new Size(220, 110);
            hoSo_Btn.TabIndex = 0;
            hoSo_Btn.Text = "Hồ sơ";
            hoSo_Btn.TextAlign = ContentAlignment.MiddleLeft;
            hoSo_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            hoSo_Btn.UseVisualStyleBackColor = true;
            hoSo_Btn.Click += button1_Click;
            // 
            // datPhong_Btn
            // 
            datPhong_Btn.Anchor = AnchorStyles.None;
            datPhong_Btn.FlatStyle = FlatStyle.Flat;
            datPhong_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            datPhong_Btn.ForeColor = Color.Gainsboro;
            datPhong_Btn.Image = Properties.Resources.booking;
            datPhong_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            datPhong_Btn.Location = new Point(-1, 225);
            datPhong_Btn.Margin = new Padding(3, 4, 3, 4);
            datPhong_Btn.Name = "datPhong_Btn";
            datPhong_Btn.Size = new Size(220, 110);
            datPhong_Btn.TabIndex = 1;
            datPhong_Btn.Text = "Đặt phòng";
            datPhong_Btn.TextAlign = ContentAlignment.MiddleLeft;
            datPhong_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            datPhong_Btn.UseVisualStyleBackColor = true;
            datPhong_Btn.Click += datPhong_Btn_Click;
            // 
            // dichVu_Btn
            // 
            dichVu_Btn.Anchor = AnchorStyles.None;
            dichVu_Btn.FlatStyle = FlatStyle.Flat;
            dichVu_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dichVu_Btn.ForeColor = Color.Gainsboro;
            dichVu_Btn.Image = Properties.Resources.room_service;
            dichVu_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            dichVu_Btn.Location = new Point(-1, 336);
            dichVu_Btn.Margin = new Padding(3, 4, 3, 4);
            dichVu_Btn.Name = "dichVu_Btn";
            dichVu_Btn.Size = new Size(220, 110);
            dichVu_Btn.TabIndex = 3;
            dichVu_Btn.Text = "Các dịch vụ ";
            dichVu_Btn.TextAlign = ContentAlignment.MiddleLeft;
            dichVu_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dichVu_Btn.UseVisualStyleBackColor = true;
            dichVu_Btn.Click += dichVu_Btn_Click;
            // 
            // bill_Btn
            // 
            bill_Btn.Anchor = AnchorStyles.None;
            bill_Btn.FlatStyle = FlatStyle.Flat;
            bill_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bill_Btn.ForeColor = Color.Gainsboro;
            bill_Btn.Image = Properties.Resources.bill;
            bill_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            bill_Btn.Location = new Point(-1, 447);
            bill_Btn.Margin = new Padding(3, 4, 3, 4);
            bill_Btn.Name = "bill_Btn";
            bill_Btn.Size = new Size(220, 110);
            bill_Btn.TabIndex = 2;
            bill_Btn.Text = "Thanh Toán";
            bill_Btn.TextAlign = ContentAlignment.MiddleLeft;
            bill_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            bill_Btn.UseVisualStyleBackColor = true;
            bill_Btn.Click += bill_Btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(222, 116);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1038, 554);
            dataGridView1.TabIndex = 3;
            // 
            // iMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dataGridView1);
            Controls.Add(panelMenu);
            Controls.Add(panelTitleBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "iMainUI";
            Text = "Trang chủ";
            Load += iMainUI_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private VScrollBar vScrollBar2;
        private VScrollBar vScrollBar1;
        private Button infoRoom_Btn;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panelLogo;
        private Label lblTitle;
        private Label lblTeam;
        private PictureBox pictureBox3;
    }
}