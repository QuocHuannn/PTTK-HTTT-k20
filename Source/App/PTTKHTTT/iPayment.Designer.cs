namespace PTTKHTTT
{
    partial class iPayment
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
            this.txtHoaDon = new System.Windows.Forms.TextBox();
            this.thanhToan_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentStatus = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đặt phòng";
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.Location = new System.Drawing.Point(172, 126);
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(357, 23);
            this.txtHoaDon.TabIndex = 18;
            // 
            // thanhToan_Btn
            // 
            this.thanhToan_Btn.Location = new System.Drawing.Point(602, 325);
            this.thanhToan_Btn.Name = "thanhToan_Btn";
            this.thanhToan_Btn.Size = new System.Drawing.Size(83, 41);
            this.thanhToan_Btn.TabIndex = 19;
            this.thanhToan_Btn.Text = "Thanh toán";
            this.thanhToan_Btn.UseVisualStyleBackColor = true;
            this.thanhToan_Btn.Click += new System.EventHandler(this.thanhToan_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tình trạng";
            // 
            // paymentStatus
            // 
            this.paymentStatus.Location = new System.Drawing.Point(172, 191);
            this.paymentStatus.Name = "paymentStatus";
            this.paymentStatus.Size = new System.Drawing.Size(357, 23);
            this.paymentStatus.TabIndex = 21;
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(56, 325);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(83, 41);
            this.find_btn.TabIndex = 22;
            this.find_btn.Text = "Tìm";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // iPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.paymentStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thanhToan_Btn);
            this.Controls.Add(this.txtHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "iPayment";
            this.Text = "iPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtHoaDon;
        private Button thanhToan_Btn;
        private Label label3;
        private TextBox paymentStatus;
        private Button find_btn;
    }
}