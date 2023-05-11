using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTTKHTTT
{
    public partial class iPayment : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public iPayment()
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
        }

        private void thanhToan_Btn_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-V9EI97MS\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True;");
            SqlConnection connection = new SqlConnection("Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True;");
            connection.Open();
            string getIdBill = txtHoaDon.Text;
            int result = Int32.Parse(getIdBill);
            Debug.WriteLine(result);
            SqlCommand sql = new SqlCommand("TinhHoaDon", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@MaDatPhong", SqlDbType.Int).Value = result; 
            SqlDataReader reader = sql.ExecuteReader();
            MessageBox.Show("Thanh toán thành công");


            
           
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            //  _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
            string getIdBill = txtHoaDon.Text;
            int result = Int32.Parse(getIdBill);
            string query = "select DaThanhToan from ChiTietDatPhong where  MaDatPhong  = "+result;

            var cmd = new SqlCommand(query, _connection);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                bool hay = (bool)reader["DaThanhToan"];
                if (hay)
                {
                    paymentStatus.Text = "Đã thanh toán";
                }
                else
                {
                    paymentStatus.Text = "Chưa Thanh toán";
                }
            }
            }
    }
}
