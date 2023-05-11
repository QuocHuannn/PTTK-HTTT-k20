using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Data.SqlClient;

namespace PTTKHTTT
{
    public partial class iReserve : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public iReserve()
        {
            InitializeComponent();
            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
                                                                                                            
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên dịch vụ được chọn từ dropdownlist
            string  tenPhong  = comboBox1.SelectedItem.ToString();

            // Tạo câu lệnh SQL để lấy thông tin chi tiết của dịch vụ dựa trên tên dịch vụ
            string sql = "SELECT TenPhong, LoaiPhong,GiaPhong FROM Phong WHERE TenPhong = N'"+tenPhong+"' and TrangThai=N'Trống'";
            // Tạo đối tượng SqlConnection để kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True"))
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenDichVu", tenPhong);

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ database
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Tạo một đối tượng DataTable mới để chứa dữ liệu lấy về
                        DataTable dataTable = new DataTable();

                        // Sử dụng đối tượng SqlDataAdapter để lấy dữ liệu từ database và đưa vào đối tượng DataTable
                        adapter.Fill(dataTable);

                        // Hiển thị dữ liệu lấy được trong DataGridView hoặc bất kỳ điều gì bạn muốn
                        searchDataGrid.DataSource = dataTable;
                    }
                }

                // Đóng kết nối đến cơ sở dữ liệu
                connection.Close();
            }
        }

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            _connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
           // _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            if (searchDataGrid.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn từ infoByName_dataGridView
                DataGridViewRow selectedRow = searchDataGrid.SelectedRows[0];

                // Tạo một mảng để chứa giá trị từ các ô của dòng được chọn
                object[] rowData = new object[selectedRow.Cells.Count];

                // Duyệt qua các ô của dòng được chọn và thêm giá trị vào mảng rowData
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }

                // Lấy giá trị ngày đặt và ngày trả từ DateTimePicker
                DateTime ngayDat = pickStart.Value;
                DateTime ngayTra = pickEnd.Value;

                // Chuyển định dạng ngày thành chuỗi để sử dụng trong câu lệnh SQL
                string ngayDatStr = ngayDat.ToString("yyyy-MM-dd");
                string ngayTraStr = ngayTra.ToString("yyyy-MM-dd");
                Debug.WriteLine(ngayDatStr);
                Debug.WriteLine(ngayTraStr);
                // Lấy mã dịch vụ từ tên dịch vụ
              //  string maPhongSql = "SELECT MaDichVu FROM DichVu WHERE TenDichVu = @TenDichVu";
            //    SqlCommand maDichVuCommand = new SqlCommand(maDichVuSql, _connection);
              //  maDichVuCommand.Parameters.AddWithValue("@TenDichVu", rowData[0]);
              //  SqlDataAdapter maDichVuAdapter = new SqlDataAdapter(maDichVuCommand);
              //  DataTable maDichVuTable = new DataTable();
               // maDichVuAdapter.Fill(maDichVuTable);
               // string maDichVu = maDichVuTable.Rows[0]["MaDichVu"].ToString();

                // Thực hiện chức năng đặt phòng với mã dịch vụ và ngày đặt/ngày trả đã lấy được
               
               string sql = "exec DatPhong  @NgayThue = '" + ngayDatStr + "', @NgayTra = '" + ngayTraStr + "'"+ ", @TenPhong=N'"+ rowData[0]+"'"+",@TamGia="+rowData[2]+", @MaKH=1";
                Debug.WriteLine(rowData[0]);
                Debug.WriteLine(rowData[2]);

                SqlCommand command = new SqlCommand(sql, _connection);
               SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                MessageBox.Show("Đặt phòng thành công");
                


            }

            _connection.Close();
        }
    }
}
