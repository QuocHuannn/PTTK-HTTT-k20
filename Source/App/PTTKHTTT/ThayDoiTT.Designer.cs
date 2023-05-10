namespace PTTKHTTT
{
    partial class ThayDoiTT
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
            label2 = new Label();
            txtName = new TextBox();
            CMND = new Label();
            txtCMND = new TextBox();
            label4 = new Label();
            txtSdt = new TextBox();
            Confirm = new Button();
            Huy = new Button();
            Gender = new Label();
            Address = new Label();
            txtGender = new TextBox();
            txtAddress = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 127);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 44);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 0;
            label1.Text = "THAY ĐỔI THÔNG TIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 153);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên người dùng";
            // 
            // txtName
            // 
            txtName.Location = new Point(251, 151);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(407, 27);
            txtName.TabIndex = 18;
            // 
            // CMND
            // 
            CMND.AutoSize = true;
            CMND.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CMND.Location = new Point(41, 211);
            CMND.Name = "CMND";
            CMND.Size = new Size(74, 28);
            CMND.TabIndex = 19;
            CMND.Text = "CMND";
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(251, 213);
            txtCMND.Margin = new Padding(3, 4, 3, 4);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(407, 27);
            txtCMND.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 287);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 21;
            label4.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(251, 284);
            txtSdt.Margin = new Padding(3, 4, 3, 4);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(407, 27);
            txtSdt.TabIndex = 22;
            txtSdt.TextChanged += txtSdt_TextChanged;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(725, 493);
            Confirm.Margin = new Padding(3, 4, 3, 4);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(95, 55);
            Confirm.TabIndex = 23;
            Confirm.Text = "Xác nhận";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // Huy
            // 
            Huy.Location = new Point(41, 493);
            Huy.Margin = new Padding(3, 4, 3, 4);
            Huy.Name = "Huy";
            Huy.Size = new Size(95, 55);
            Huy.TabIndex = 24;
            Huy.Text = "Hủy";
            Huy.UseVisualStyleBackColor = true;
            Huy.Click += Huy_Click;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Gender.Location = new Point(41, 353);
            Gender.Name = "Gender";
            Gender.Size = new Size(95, 28);
            Gender.TabIndex = 25;
            Gender.Text = "Giới tính";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Address.Location = new Point(41, 413);
            Address.Name = "Address";
            Address.Size = new Size(78, 28);
            Address.TabIndex = 26;
            Address.Text = "Địa chỉ";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(251, 351);
            txtGender.Margin = new Padding(3, 4, 3, 4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(407, 27);
            txtGender.TabIndex = 27;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(251, 411);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(407, 27);
            txtAddress.TabIndex = 28;
            // 
            // ThayDoiTT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(Address);
            Controls.Add(Gender);
            Controls.Add(Huy);
            Controls.Add(Confirm);
            Controls.Add(txtSdt);
            Controls.Add(label4);
            Controls.Add(txtCMND);
            Controls.Add(CMND);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ThayDoiTT";
            Text = "ThayDoiTT";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label CMND;
        private TextBox txtCMND;
        private Label label4;
        private TextBox txtSdt;
        private Button Confirm;
        private Button Huy;
        private Label Gender;
        private Label Address;
        private TextBox txtGender;
        private TextBox txtAddress;
    }
}