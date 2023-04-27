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
            dangXuat_Btn = new Button();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            panelLogo = new Panel();
            pictureBox3 = new PictureBox();
            lblTeam = new Label();
            infoRoom_Btn = new Button();
            hoSo_Btn = new Button();
            datPhong_Btn = new Button();
            dichVu_Btn = new Button();
            bill_Btn = new Button();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(739, 12);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 2;
            label2.Text = "Xin chào, Bùn Ngủ";
            // 
            // panelTitleBar
            // 
            panelTitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.BorderStyle = BorderStyle.FixedSingle;
            panelTitleBar.Controls.Add(dangXuat_Btn);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(pictureBox1);
            panelTitleBar.Controls.Add(label2);
            panelTitleBar.Location = new Point(221, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1038, 115);
            panelTitleBar.TabIndex = 1;
            // 
            // dangXuat_Btn
            // 
            dangXuat_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dangXuat_Btn.Image = Properties.Resources.logout1;
            dangXuat_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            dangXuat_Btn.Location = new Point(761, 52);
            dangXuat_Btn.Name = "dangXuat_Btn";
            dangXuat_Btn.Size = new Size(143, 40);
            dangXuat_Btn.TabIndex = 8;
            dangXuat_Btn.Text = "Đăng xuất";
            dangXuat_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dangXuat_Btn.UseVisualStyleBackColor = true;
            dangXuat_Btn.Click += dangXuat_Btn_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(415, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(218, 46);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "TRANG CHỦ";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(948, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            lblTeam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
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

            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(556, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xin chào, Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.vScrollBar2);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 55);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PTTKHTTT.Properties.Resources.kisspng_united_states_avatar_organization_information_user_avatar_5ac20804a62b58_8673620215226654766806;
            this.pictureBox1.Location = new System.Drawing.Point(715, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 399);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hồ sơ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(0, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đặt phòng";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(0, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 80);
            this.button4.TabIndex = 2;
            this.button4.Text = "Thanh Toán";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(0, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 80);
            this.button5.TabIndex = 3;
            this.button5.Text = "Các dịch vụ ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(178, 52);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(9, 402);
            this.vScrollBar1.TabIndex = 4;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(174, 52);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(34, 400);
            this.vScrollBar2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(0, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 93);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thông tin đặt phòng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PTTKHTTT.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(621, 396);
            this.dataGridView1.TabIndex = 3;
            // 
            // iMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelMenu);
            Controls.Add(panelTitleBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "iMainUI";
            Text = "TRANG CHỦ";
            Load += iMainUI_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đăng xuất";
            // 
            // iMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "iMainUI";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.iMainUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private Panel panel1;
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
        private PictureBox pictureBox3;
        private Button dangXuat_Btn;
        private Panel panel2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button2;
        private VScrollBar vScrollBar2;
        private VScrollBar vScrollBar1;
        private Button button3;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}