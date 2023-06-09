﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PTTKHTTT
{
    public partial class iService : Form
    {
        //Make connection into DB
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";

        bool isColAdded = false;

        public iService()
        {
            InitializeComponent();

            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
        }
        private void iService_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
        }

        private void infoService_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirm_Btn_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in addedService_dataGridView.Rows)
            {
                // Lấy giá trị trong cột "GiaDichVu"
                decimal giaDichVu = Convert.ToDecimal(row.Cells["GiaDichVu"].Value);

                // Tính toán giá tiền tương ứng và cộng vào tổng giá tiền
                totalPrice += giaDichVu;
            }

            // Hiển thị tổng giá tiền cho tất cả các dịch vụ đã chọn
            MessageBox.Show("Tổng giá tiền: " + totalPrice.ToString() + ". Cảm ơn bạn đã chọn dịch vụ của SLEEPING !");
        }

        private void findService_Btn_Click(object sender, EventArgs e)
        {
            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            if (_connection.State == ConnectionState.Open)
            {
                Debug.WriteLine("Kết nối DB thành công");
            }
            else
            {
                Debug.WriteLine("Kết nối DB thất bại");
            }

            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            string keyword = find_txt.Text;

            String sql = "exec ShowDichVuByTen " + " @TenDichVu =N'" + keyword + "'";


            //Bước 3: Tạo đối tượng thực thi câu lệnh SQL
            SqlDataAdapter adapt = new SqlDataAdapter(sql, _connection);
            DataSet dts = new DataSet();

            adapt.Fill(dts);

            DataTable table = dts.Tables[0];
            table.Columns["TenDichVu"].ColumnName = "Tên Dịch Vụ";
            table.Columns["GiaDichVu"].ColumnName = "Giá Dịch Vụ";
            table.Columns.Remove("MaDichVu");
            table.Columns.Remove("ThongTinDV");
            if (dts.Tables.Count > 0)
            {
                //Dua du lieu vao combo_box
                infoByName_dataGridView.DataSource = table;

            }
            _connection.Close();

        }

        private void addService_Btn_Click(object sender, EventArgs e)
        {
            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            if (_connection.State == ConnectionState.Open)
            {
                Debug.WriteLine("Kết nối DB thành công");
            }
            else
            {
                Debug.WriteLine("Kết nối DB thất bại");
            }

            if (!isColAdded)
            {
                addedService_dataGridView.Columns.Add("TenDichVu", "Tên Dịch Vụ");
                addedService_dataGridView.Columns.Add("GiaDichVu", "Giá Dịch Vụ");
                isColAdded = true;
            }


            if (infoByName_dataGridView.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn từ infoByName_dataGridView
                DataGridViewRow selectedRow = infoByName_dataGridView.SelectedRows[0];

                // Tạo một mảng để chứa giá trị từ các ô của dòng được chọn
                object[] rowData = new object[selectedRow.Cells.Count];

                // Duyệt qua các ô của dòng được chọn và thêm giá trị vào mảng rowData
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào addedService_dataGridView bằng cách sử dụng mảng rowData
                addedService_dataGridView.Rows.Add(rowData);

                //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
                string sql = "select MaDichVu from DichVu where TenDichVu = N'" + rowData[0] + "'";
                //Bước 3: Tạo đối tượng thực thi câu lệnh SQL
                SqlCommand command = new SqlCommand(sql, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                string keyword = dataTable.Rows[0]["MaDichVu"].ToString();
                Debug.WriteLine(keyword);

                String sql2 = "exec ThemDichVuVaoDatPhong " + " @MaDatPhong = 1, @MaDichVu = " + keyword + ", @SoLuong = 10";
                SqlCommand command2 = new SqlCommand(sql2, _connection);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
            }

            _connection.Close();
        }

        private void infoByName_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy index của dòng vừa được nhấn
            int rowIdx = e.RowIndex;

            // Lấy tên dịch vụ từ cột TenDichVu (index 1) của dòng đó
            string tenDichVu = infoByName_dataGridView.Rows[rowIdx].Cells[0].Value.ToString();

            Debug.WriteLine(tenDichVu);

            // Tạo câu lệnh SQL để lấy thông tin chi tiết của dịch vụ dựa trên tên dịch vụ
            string sql = "SELECT ThongTinDV AS 'Thông tin dịch vụ' FROM DichVu WHERE TenDichVu = @TenDichVu";

            // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True"))
            //using (SqlConnection connection = new SqlConnection(@"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True"))

            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenDichVu", tenDichVu);

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ database
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Tạo một đối tượng DataTable mới để chứa dữ liệu lấy về
                        DataTable dataTable = new DataTable();

                        // Sử dụng đối tượng SqlDataAdapter để lấy dữ liệu từ database và đưa vào đối tượng DataTable
                        adapter.Fill(dataTable);

                        // Hiển thị dữ liệu lấy được trong DataGridView infoService_dataGridView
                        infoService_dataGridView.DataSource = dataTable;
                    }
                }

                // Đóng kết nối đến cơ sở dữ liệu
                connection.Close();
            }
        }

        private void addedService_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy index của dòng vừa được nhấn
            int rowIdx = e.RowIndex;

            // Lấy tên dịch vụ từ cột TenDichVu (index 1) của dòng đó
            string tenDichVu = infoByName_dataGridView.Rows[rowIdx].Cells[0].Value.ToString();

            Debug.WriteLine(tenDichVu);

            // Tạo câu lệnh SQL để lấy thông tin chi tiết của dịch vụ dựa trên tên dịch vụ
            string sql = "SELECT ThongTinDV AS 'Thông tin dịch vụ' FROM DichVu WHERE TenDichVu = @TenDichVu";

            // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True"))
            //using (SqlConnection connection = new SqlConnection(@"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True"))
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenDichVu", tenDichVu);

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ database
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Tạo một đối tượng DataTable mới để chứa dữ liệu lấy về
                        DataTable dataTable = new DataTable();

                        // Sử dụng đối tượng SqlDataAdapter để lấy dữ liệu từ database và đưa vào đối tượng DataTable
                        adapter.Fill(dataTable);

                        // Hiển thị dữ liệu lấy được trong DataGridView infoService_dataGridView
                        infoService_dataGridView.DataSource = dataTable;
                    }
                }

                // Đóng kết nối đến cơ sở dữ liệu
                connection.Close();
            }
        }

        private void xoaTT_Btn_Click(object sender, EventArgs e)
        {
            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            if (_connection.State == ConnectionState.Open)
            {
                Debug.WriteLine("Kết nối DB thành công");
            }
            else
            {
                Debug.WriteLine("Kết nối DB thất bại");
            }

            if (!isColAdded)
            {
                addedService_dataGridView.Columns.Add("TenDichVu", "Tên Dịch Vụ");
                addedService_dataGridView.Columns.Add("GiaDichVu", "Giá Dịch Vụ");
                isColAdded = true;
            }


            if (addedService_dataGridView.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn từ infoByName_dataGridView
                DataGridViewRow selectedRow = addedService_dataGridView.SelectedRows[0];

                // Tạo một mảng để chứa giá trị từ các ô của dòng được chọn
                object[] rowData = new object[selectedRow.Cells.Count];

                // Duyệt qua các ô của dòng được chọn và thêm giá trị vào mảng rowData
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }

                // Gọi hàm xóa dòng trong thread giao diện chính của ứng dụng
                addedService_dataGridView.BeginInvoke(new Action(() => addedService_dataGridView.Rows.Remove(selectedRow)));


                //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
                string sql = "select MaDichVu from DichVu where TenDichVu = N'" + rowData[0] + "'";
                //Bước 3: Tạo đối tượng thực thi câu lệnh SQL
                SqlCommand command = new SqlCommand(sql, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                string keyword = dataTable.Rows[0]["MaDichVu"].ToString();
                Debug.WriteLine(keyword);

                String sql2 = "EXEC XoaThongTin @MaDatPhong = 1, @MaDichVu = " + keyword;
                SqlCommand command2 = new SqlCommand(sql2, _connection);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
            }

            _connection.Close();

        }
    }
}
