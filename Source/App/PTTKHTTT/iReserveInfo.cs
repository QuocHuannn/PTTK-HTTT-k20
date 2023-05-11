using System;
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
    public partial class iReserveInfo : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";

        public iReserveInfo()
        {
            InitializeComponent();

            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            iMainUI trangChu = new iMainUI();
            trangChu.Show();
        }

        private void iReserveInfo_Load(object sender, EventArgs e)
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
            label6.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findReser_Btn_Click(object sender, EventArgs e)
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
            string keyword = ma_txt.Text;
            //string keyword2 = name_txt.Text;
            //string keyword3 = sdt_txt.Text;
            //string keyword4 = phong_txt.Text;

            //String sql = "select dv.TenDichVu, dv.GiaDichVu from DatPhongDichVu as dpdv, DichVu as dv, KhachHang as kh, ChiTietDatPhong as ct, HoaDon as hd  " +
            //    "where kh.MaKH = ct.MaKH and ct.MaDatPhong = hd.MaDatPhong and ct.MaDatPhong = dpdv.MaDatPhong and dpdv.MaDichVu = dv.MaDichVu " +
            //    "and kh.HoTen =" + keyword2 + "and hd.MaHoaDon =" + keyword + "and kh.Sdt = " + keyword3 + "and hd.MaPhong = " + keyword4;

            String sql = "select dv.TenDichVu, dv.GiaDichVu " +
                "from DatPhongDichVu as dpdv, DichVu as dv,  HoaDon as hd " +
                "where dpdv.MaDichVu = dv.MaDichVu and hd.MaDatPhong = dpdv.MaDatPhong and hd.MaHoaDon =" + keyword;

            String query = "select HoTen, Sdt, HD.MaDatPhong from KhachHang AS KH, ChiTietDatPhong AS CT, HOADON AS HD where  KH.MaKH  = CT.MaKH AND HD.MaHoaDon = " + keyword;


            var adapt = new SqlDataAdapter();
            adapt.SelectCommand = new SqlCommand(sql, _connection);

            DataSet dts = new DataSet();
            adapt.Fill(dts);

            DataTable table = dts.Tables[0];
            table.Columns["TenDichVu"].ColumnName = "Tên Dịch Vụ";
            table.Columns["GiaDichVu"].ColumnName = "Giá Dịch Vụ";
            var cmd = new SqlCommand(query, _connection);

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var hoTen = reader.GetString("HoTen");
                var sdt = reader.GetString("Sdt");
                var soPhong = reader.GetValue("MaDatPhong");

                name_txt.Text = hoTen;
                sdt_txt.Text = sdt;
                phong_txt.Text = soPhong.ToString();
            }
            if (dts.Tables.Count > 0)
            {
                //Dua du lieu vao combo_box
                dichVuGrid.DataSource = table;

            }
            _connection.Close();

        }
    }
}
