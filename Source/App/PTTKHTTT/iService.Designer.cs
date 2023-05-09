namespace PTTKHTTT
{
    partial class iService
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
            addService_Btn = new Button();
            findService_Btn = new Button();
            find_txt = new TextBox();
            label2 = new Label();
            infoByName_dataGridView = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            infoService_dataGridView = new DataGridView();
            confirm_Btn = new Button();
            button5 = new Button();
            button3 = new Button();
            addedService_dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)infoByName_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoService_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addedService_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // addService_Btn
            // 
            addService_Btn.Anchor = AnchorStyles.None;
            addService_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addService_Btn.Location = new Point(339, 216);
            addService_Btn.Margin = new Padding(3, 4, 3, 4);
            addService_Btn.Name = "addService_Btn";
            addService_Btn.Size = new Size(224, 31);
            addService_Btn.TabIndex = 4;
            addService_Btn.Text = "Thêm vào danh sách";
            addService_Btn.UseVisualStyleBackColor = true;
            addService_Btn.Click += addService_Btn_Click;
            // 
            // findService_Btn
            // 
            findService_Btn.Anchor = AnchorStyles.None;
            findService_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            findService_Btn.Location = new Point(481, 55);
            findService_Btn.Margin = new Padding(3, 4, 3, 4);
            findService_Btn.Name = "findService_Btn";
            findService_Btn.Size = new Size(82, 31);
            findService_Btn.TabIndex = 3;
            findService_Btn.Text = "Tìm kiếm";
            findService_Btn.UseVisualStyleBackColor = true;
            findService_Btn.Click += findService_Btn_Click;
            // 
            // find_txt
            // 
            find_txt.Anchor = AnchorStyles.None;
            find_txt.Location = new Point(259, 54);
            find_txt.Margin = new Padding(3, 4, 3, 4);
            find_txt.Name = "find_txt";
            find_txt.PlaceholderText = "Tìm kiếm...";
            find_txt.Size = new Size(216, 27);
            find_txt.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 50);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 1;
            label2.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // infoByName_dataGridView
            // 
            infoByName_dataGridView.Anchor = AnchorStyles.None;
            infoByName_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoByName_dataGridView.Location = new Point(42, 94);
            infoByName_dataGridView.Margin = new Padding(3, 4, 3, 4);
            infoByName_dataGridView.Name = "infoByName_dataGridView";
            infoByName_dataGridView.RowHeadersWidth = 51;
            infoByName_dataGridView.Size = new Size(521, 114);
            infoByName_dataGridView.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 275);
            label3.Name = "label3";
            label3.Size = new Size(346, 28);
            label3.TabIndex = 2;
            label3.Text = "DANH SÁCH DỊCH VỤ ĐƯỢC CHỌN";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(634, 50);
            label4.Name = "label4";
            label4.Size = new Size(210, 28);
            label4.TabIndex = 5;
            label4.Text = "THÔNG TIN CHI TIẾT";
            // 
            // infoService_dataGridView
            // 
            infoService_dataGridView.Anchor = AnchorStyles.None;
            infoService_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoService_dataGridView.Location = new Point(634, 94);
            infoService_dataGridView.Margin = new Padding(3, 4, 3, 4);
            infoService_dataGridView.Name = "infoService_dataGridView";
            infoService_dataGridView.RowHeadersWidth = 51;
            infoService_dataGridView.RowTemplate.Height = 25;
            infoService_dataGridView.Size = new Size(414, 327);
            infoService_dataGridView.TabIndex = 6;
            infoService_dataGridView.CellContentClick += infoService_dataGridView_CellContentClick;
            // 
            // confirm_Btn
            // 
            confirm_Btn.Anchor = AnchorStyles.None;
            confirm_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirm_Btn.Location = new Point(784, 429);
            confirm_Btn.Margin = new Padding(3, 4, 3, 4);
            confirm_Btn.Name = "confirm_Btn";
            confirm_Btn.Size = new Size(264, 31);
            confirm_Btn.TabIndex = 5;
            confirm_Btn.Text = "Xác nhận";
            confirm_Btn.UseVisualStyleBackColor = true;
            confirm_Btn.Click += confirm_Btn_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(634, 429);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(134, 31);
            button5.TabIndex = 7;
            button5.Text = "Quay lại";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(339, 429);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(224, 31);
            button3.TabIndex = 5;
            button3.Text = "Xóa khỏi danh sách";
            button3.UseVisualStyleBackColor = true;
            // 
            // addedService_dataGridView
            // 
            addedService_dataGridView.Anchor = AnchorStyles.None;
            addedService_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addedService_dataGridView.Location = new Point(42, 307);
            addedService_dataGridView.Margin = new Padding(3, 4, 3, 4);
            addedService_dataGridView.Name = "addedService_dataGridView";
            addedService_dataGridView.RowHeadersWidth = 51;
            addedService_dataGridView.Size = new Size(521, 114);
            addedService_dataGridView.TabIndex = 5;
            // 
            // iService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 561);
            Controls.Add(label2);
            Controls.Add(findService_Btn);
            Controls.Add(addService_Btn);
            Controls.Add(find_txt);
            Controls.Add(label3);
            Controls.Add(addedService_dataGridView);
            Controls.Add(infoByName_dataGridView);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(confirm_Btn);
            Controls.Add(infoService_dataGridView);
            Controls.Add(label4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "iService";
            Text = "DỊCH VỤ";
            Load += iService_Load;
            ((System.ComponentModel.ISupportInitialize)infoByName_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoService_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addedService_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addService_Btn;
        private Button findService_Btn;
        private TextBox find_txt;
        private Label label2;
        private DataGridView infoByName_dataGridView;
        private Label label3;
        private Label label4;
        private DataGridView infoService_dataGridView;
        private Button confirm_Btn;
        private Button button5;
        private Button button3;
        private DataGridView addedService_dataGridView;
    }
}