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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMND = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người dùng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CMND
            // 
            this.CMND.AutoSize = true;
            this.CMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CMND.Location = new System.Drawing.Point(68, 212);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(60, 21);
            this.CMND.TabIndex = 2;
            this.CMND.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "Thay đổi";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 158);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 23);
            this.txtName.TabIndex = 17;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(176, 210);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(357, 23);
            this.txtCMND.TabIndex = 18;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(176, 262);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(357, 23);
            this.txtSdt.TabIndex = 19;
            // 
            // iProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CMND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "iProfile";
            this.Text = "Hồ sơ";
            this.Load += new System.EventHandler(this.iProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label CMND;
        private Label label4;
        private Button button3;
        private TextBox txtName;
        private TextBox txtCMND;
        private TextBox txtSdt;
    }
}