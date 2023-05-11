namespace PTTKHTTT
{
    partial class iReserveInfo
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
            ma_txt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            name_txt = new TextBox();
            phong_txt = new TextBox();
            panel2 = new Panel();
            dichVuGrid = new DataGridView();
            label6 = new Label();
            findReser_Btn = new Button();
            sdt_txt = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dichVuGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 97);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã đơn";
            // 
            // ma_txt
            // 
            ma_txt.Anchor = AnchorStyles.None;
            ma_txt.Location = new Point(184, 98);
            ma_txt.Margin = new Padding(3, 4, 3, 4);
            ma_txt.Name = "ma_txt";
            ma_txt.Size = new Size(283, 27);
            ma_txt.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 167);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 3;
            label3.Text = "Tên người đặt";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 312);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 5;
            label5.Text = "Số phòng";
            // 
            // name_txt
            // 
            name_txt.Anchor = AnchorStyles.None;
            name_txt.Location = new Point(184, 168);
            name_txt.Margin = new Padding(3, 4, 3, 4);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(283, 27);
            name_txt.TabIndex = 7;
            // 
            // phong_txt
            // 
            phong_txt.Anchor = AnchorStyles.None;
            phong_txt.Location = new Point(184, 313);
            phong_txt.Margin = new Padding(3, 4, 3, 4);
            phong_txt.Name = "phong_txt";
            phong_txt.Size = new Size(283, 27);
            phong_txt.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(dichVuGrid);
            panel2.Location = new Point(515, 97);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(533, 321);
            panel2.TabIndex = 11;
            // 
            // dichVuGrid
            // 
            dichVuGrid.Anchor = AnchorStyles.None;
            dichVuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dichVuGrid.Location = new Point(0, 0);
            dichVuGrid.Name = "dichVuGrid";
            dichVuGrid.RowHeadersWidth = 51;
            dichVuGrid.RowTemplate.Height = 29;
            dichVuGrid.Size = new Size(533, 321);
            dichVuGrid.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(515, 61);
            label6.Name = "label6";
            label6.Size = new Size(242, 32);
            label6.TabIndex = 12;
            label6.Text = "DỊCH VỤ KÈM THEO";
            // 
            // findReser_Btn
            // 
            findReser_Btn.Anchor = AnchorStyles.None;
            findReser_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            findReser_Btn.Location = new Point(184, 387);
            findReser_Btn.Name = "findReser_Btn";
            findReser_Btn.Size = new Size(283, 31);
            findReser_Btn.TabIndex = 15;
            findReser_Btn.Text = "Tìm kiếm";
            findReser_Btn.UseVisualStyleBackColor = true;
            findReser_Btn.Click += findReser_Btn_Click;
            // 
            // sdt_txt
            // 
            sdt_txt.Anchor = AnchorStyles.None;
            sdt_txt.Location = new Point(184, 241);
            sdt_txt.Margin = new Padding(3, 4, 3, 4);
            sdt_txt.Name = "sdt_txt";
            sdt_txt.Size = new Size(283, 27);
            sdt_txt.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 240);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // iReserveInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 561);
            Controls.Add(findReser_Btn);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(phong_txt);
            Controls.Add(sdt_txt);
            Controls.Add(name_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ma_txt);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "iReserveInfo";
            Text = "THÔNG TIN ĐẶT PHÒNG";
            Load += iReserveInfo_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dichVuGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox ma_txt;
        private Label label3;
        private Label label5;
        private TextBox name_txt;
        private TextBox phong_txt;
        private Panel panel2;
        private Label label6;
        private DataGridView dichVuGrid;
        private Button findReser_Btn;
        private TextBox sdt_txt;
        private Label label4;
    }
}