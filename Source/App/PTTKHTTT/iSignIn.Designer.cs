namespace PTTKHTTT
{
    partial class iSignIn
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            signIn_Btn = new Button();
            logIn_Btn = new Button();
            panel4 = new Panel();
            textBox2 = new TextBox();
            passIcon = new PictureBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            userNameIcon = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passIcon).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 707);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 195);
            label1.Name = "label1";
            label1.Size = new Size(285, 37);
            label1.TabIndex = 3;
            label1.Text = "Đặt phòng khách sạn";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.sleeping2;
            pictureBox1.Image = Properties.Resources.sleeping2;
            pictureBox1.InitialImage = Properties.Resources.sleeping1;
            pictureBox1.Location = new Point(133, 115);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 76);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnMaximize);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(signIn_Btn);
            panel2.Controls.Add(logIn_Btn);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(343, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 707);
            panel2.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.Lime;
            btnMinimize.Location = new Point(390, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 40);
            btnMinimize.TabIndex = 14;
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
            btnMaximize.Location = new Point(436, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 40);
            btnMaximize.TabIndex = 13;
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
            btnClose.Location = new Point(474, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 12;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // signIn_Btn
            // 
            signIn_Btn.BackColor = Color.FromArgb(41, 128, 185);
            signIn_Btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            signIn_Btn.ForeColor = Color.White;
            signIn_Btn.Location = new Point(17, 455);
            signIn_Btn.Margin = new Padding(3, 4, 3, 4);
            signIn_Btn.Name = "signIn_Btn";
            signIn_Btn.Size = new Size(150, 56);
            signIn_Btn.TabIndex = 8;
            signIn_Btn.Text = "Đăng ký";
            signIn_Btn.UseVisualStyleBackColor = false;
            signIn_Btn.Click += signIn_Btn_Click;
            // 
            // logIn_Btn
            // 
            logIn_Btn.BackColor = Color.FromArgb(41, 128, 185);
            logIn_Btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            logIn_Btn.ForeColor = Color.White;
            logIn_Btn.Location = new Point(341, 455);
            logIn_Btn.Margin = new Padding(3, 4, 3, 4);
            logIn_Btn.Name = "logIn_Btn";
            logIn_Btn.Size = new Size(150, 56);
            logIn_Btn.TabIndex = 7;
            logIn_Btn.Text = "Đăng nhập";
            logIn_Btn.UseVisualStyleBackColor = false;
            logIn_Btn.Click += logIn_Btn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(passIcon);
            panel4.Location = new Point(0, 324);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(514, 60);
            panel4.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(67, 15);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(423, 20);
            textBox2.TabIndex = 8;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // passIcon
            // 
            passIcon.Image = Properties.Resources.key1;
            passIcon.Location = new Point(17, 15);
            passIcon.Margin = new Padding(3, 4, 3, 4);
            passIcon.Name = "passIcon";
            passIcon.Size = new Size(27, 32);
            passIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            passIcon.TabIndex = 1;
            passIcon.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(userNameIcon);
            panel3.Location = new Point(0, 256);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 60);
            panel3.TabIndex = 5;
            panel3.Click += textBox1_TextChanged;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(67, 16);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 20);
            textBox1.TabIndex = 7;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // userNameIcon
            // 
            userNameIcon.Image = Properties.Resources.user2;
            userNameIcon.InitialImage = null;
            userNameIcon.Location = new Point(17, 15);
            userNameIcon.Margin = new Padding(3, 4, 3, 4);
            userNameIcon.Name = "userNameIcon";
            userNameIcon.Size = new Size(27, 32);
            userNameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userNameIcon.TabIndex = 0;
            userNameIcon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(163, 195);
            label2.Name = "label2";
            label2.Size = new Size(181, 37);
            label2.TabIndex = 4;
            label2.Text = "ĐĂNG NHẬP";
            label2.Click += label2_Click;
            // 
            // iSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 128, 185);
            ClientSize = new Size(857, 707);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "iSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += iSignIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passIcon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userNameIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button signIn_Btn;
        private Button logIn_Btn;
        private Panel panel4;
        private TextBox textBox2;
        private PictureBox passIcon;
        private Panel panel3;
        private TextBox textBox1;
        private PictureBox userNameIcon;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
    }
}