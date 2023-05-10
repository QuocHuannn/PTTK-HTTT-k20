namespace PTTKHTTT
{
    partial class iProfile
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
            CMND = new Label();
            label4 = new Label();
            change_Btn = new Button();
            txtName = new TextBox();
            txtCMND = new TextBox();
            txtSdt = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 127);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 44);
            label1.Name = "label1";
            label1.Size = new Size(394, 41);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 208);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên người dùng";
            label2.Click += label2_Click;
            // 
            // CMND
            // 
            CMND.AutoSize = true;
            CMND.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CMND.Location = new Point(78, 283);
            CMND.Name = "CMND";
            CMND.Size = new Size(74, 28);
            CMND.TabIndex = 2;
            CMND.Text = "CMND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(57, 349);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // change_Btn
            // 
            change_Btn.Location = new Point(375, 404);
            change_Btn.Margin = new Padding(3, 4, 3, 4);
            change_Btn.Name = "change_Btn";
            change_Btn.Size = new Size(95, 55);
            change_Btn.TabIndex = 13;
            change_Btn.Text = "Thay đổi";
            change_Btn.UseVisualStyleBackColor = true;
            change_Btn.Click += change_Btn_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(201, 211);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(407, 27);
            txtName.TabIndex = 17;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(201, 280);
            txtCMND.Margin = new Padding(3, 4, 3, 4);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(407, 27);
            txtCMND.TabIndex = 18;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(201, 349);
            txtSdt.Margin = new Padding(3, 4, 3, 4);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(407, 27);
            txtSdt.TabIndex = 19;
            // 
            // iProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtSdt);
            Controls.Add(txtCMND);
            Controls.Add(txtName);
            Controls.Add(change_Btn);
            Controls.Add(label4);
            Controls.Add(CMND);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "iProfile";
            Text = "Hồ sơ";
            Load += iProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label CMND;
        private Label label4;
        private Button change_Btn;
        private TextBox txtName;
        private TextBox txtCMND;
        private TextBox txtSdt;
    }
}