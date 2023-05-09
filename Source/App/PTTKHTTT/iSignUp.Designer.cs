namespace PTTKHTTT
{
    partial class iSignUp
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
            backSignIn_Btn = new Button();
            valiSignUp_Btn = new Button();
            panel6 = new Panel();
            textBox4 = new TextBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel5 = new Panel();
            textBox3 = new TextBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
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
            label1.TabIndex = 4;
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnMaximize);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(backSignIn_Btn);
            panel2.Controls.Add(valiSignUp_Btn);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
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
            btnMinimize.Location = new Point(390, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 40);
            btnMinimize.TabIndex = 17;
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
            btnMaximize.Location = new Point(436, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 40);
            btnMaximize.TabIndex = 16;
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
            btnClose.Location = new Point(474, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 15;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // backSignIn_Btn
            // 
            backSignIn_Btn.BackColor = Color.FromArgb(41, 128, 185);
            backSignIn_Btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            backSignIn_Btn.ForeColor = Color.White;
            backSignIn_Btn.Location = new Point(341, 635);
            backSignIn_Btn.Margin = new Padding(3, 4, 3, 4);
            backSignIn_Btn.Name = "backSignIn_Btn";
            backSignIn_Btn.Size = new Size(150, 56);
            backSignIn_Btn.TabIndex = 13;
            backSignIn_Btn.Text = "Đăng nhập";
            backSignIn_Btn.UseVisualStyleBackColor = false;
            backSignIn_Btn.Click += backSignIn_Btn_Click;
            // 
            // valiSignUp_Btn
            // 
            valiSignUp_Btn.BackColor = Color.FromArgb(41, 128, 185);
            valiSignUp_Btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            valiSignUp_Btn.ForeColor = Color.White;
            valiSignUp_Btn.Location = new Point(166, 576);
            valiSignUp_Btn.Margin = new Padding(3, 4, 3, 4);
            valiSignUp_Btn.Name = "valiSignUp_Btn";
            valiSignUp_Btn.Size = new Size(150, 56);
            valiSignUp_Btn.TabIndex = 12;
            valiSignUp_Btn.Text = "Đăng ký";
            valiSignUp_Btn.UseVisualStyleBackColor = false;
            valiSignUp_Btn.Click += valiSignUp_Btn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(textBox4);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(0, 501);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(514, 53);
            panel6.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(67, 15);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(423, 20);
            textBox4.TabIndex = 8;
            textBox4.Click += phone_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(17, 15);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 471);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 11;
            label6.Text = "Số điện thoại";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(0, 400);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(514, 53);
            panel5.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(67, 15);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(423, 20);
            textBox3.TabIndex = 8;
            textBox3.Click += name_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(17, 15);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 369);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 10;
            label5.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 281);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 9;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 184);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 8;
            label3.Text = "Tên đăng nhập";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 312);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(514, 53);
            panel4.TabIndex = 7;
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
            textBox2.Click += password_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(17, 15);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 215);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 53);
            panel3.TabIndex = 6;
            panel3.Click += username_Click;
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
            textBox1.Click += username_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(17, 15);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(166, 115);
            label2.Name = "label2";
            label2.Size = new Size(137, 37);
            label2.TabIndex = 5;
            label2.Text = "ĐĂNG KÝ";
            // 
            // iSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 707);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "iSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iSignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Panel panel6;
        private TextBox textBox4;
        private PictureBox pictureBox5;
        private Label label6;
        private Panel panel5;
        private TextBox textBox3;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Button valiSignUp_Btn;
        private Button backSignIn_Btn;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
    }
}