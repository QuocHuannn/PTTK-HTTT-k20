namespace PTTKHTTT
{
    partial class iReserve
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
            this.label1 = new System.Windows.Forms.Label();
            this.pickStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pickEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchDataGrid = new System.Windows.Forms.DataGridView();
            this.reserve_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pickStart
            // 
            this.pickStart.Location = new System.Drawing.Point(102, 22);
            this.pickStart.Name = "pickStart";
            this.pickStart.Size = new System.Drawing.Size(200, 23);
            this.pickStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // pickEnd
            // 
            this.pickEnd.Location = new System.Drawing.Point(102, 60);
            this.pickEnd.Name = "pickEnd";
            this.pickEnd.Size = new System.Drawing.Size(200, 23);
            this.pickEnd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(331, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên phòng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi",
            "Phòng view đẹp",
            "Phòng gia đình",
            "Phòng suit",
            "Phòng President"});
            this.comboBox1.Location = new System.Drawing.Point(436, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchDataGrid
            // 
            this.searchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGrid.Location = new System.Drawing.Point(0, 159);
            this.searchDataGrid.Name = "searchDataGrid";
            this.searchDataGrid.RowTemplate.Height = 25;
            this.searchDataGrid.Size = new System.Drawing.Size(805, 295);
            this.searchDataGrid.TabIndex = 10;
            // 
            // reserve_btn
            // 
            this.reserve_btn.Location = new System.Drawing.Point(436, 75);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(83, 41);
            this.reserve_btn.TabIndex = 15;
            this.reserve_btn.Text = "Đặt phòng";
            this.reserve_btn.UseVisualStyleBackColor = true;
            this.reserve_btn.Click += new System.EventHandler(this.reserve_btn_Click);
            // 
            // iReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserve_btn);
            this.Controls.Add(this.searchDataGrid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickStart);
            this.Controls.Add(this.label1);
            this.Name = "iReserve";
            this.Text = "iReserve";
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker pickStart;
        private Label label2;
        private DateTimePicker pickEnd;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox1;
        private DataGridView searchDataGrid;
        private Button reserve_btn;
    }
}