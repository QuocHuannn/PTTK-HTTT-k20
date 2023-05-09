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
using System.Data.SqlClient;
using System.Diagnostics;

namespace PTTKHTTT
{
    public partial class iService : Form
    {
        //Make connection into DB
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";


        public iService()
        {
            InitializeComponent();

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
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            if (_connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Kết nối DB thành công");
            }
            else
            {
                Console.WriteLine("Kết nối DB thất bại");
            }

            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            //string keyword = txtbMaDoiTac.Text;
            //string keyword2 = txtbGiaMon.Text;



            //String sql = "exec T1_demo " + " @GiaMon ='" + keyword2 + "', @MaDoiTac_demo = '" + keyword + "'";
            //String sql2 = "select * from dbo.ChiTietTHucDon where MaDoiTac = '" + keyword + "'";
            //String sql = "update Phong set TenPhong = 'Phòng đơn' where MaPhong = 101;";

            String sql = "exec ShowDichVuByTen N'giặt là'";


            //Bước 3: Tạo đối tượng thực thi câu lệnh SQL
            SqlDataAdapter adapt = new SqlDataAdapter(sql, _connection);
            //SqlDataAdapter adapt2 = new SqlDataAdapter(sql2, _connection);
            DataSet dts = new DataSet();
            //DataSet dts2 = new DataSet();

            adapt.Fill(dts);
            //adapt2.Fill(dts2);

            if (dts.Tables.Count > 0)
            {
                //Dua du lieu vao combo_box
                infoService_dataGridView.DataSource = dts.Tables[0];
            }
            //if (dts2.Tables.Count > 0)
            //{

            //    //Dua du lieu vao combo_box
            //    gridView2.DataSource = dts2.Tables[0];
            //}


        }
    }
}
