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
            SqlCommand sql = new SqlCommand("TinhHoaDon", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@MaDatPhong", SqlDbType.Int).Value = result;
            try
            {
                SqlDataReader reader = sql.ExecuteReader();
                MessageBox.Show("Thay doi thanh cong");


            }
            catch (Exception)
            {
                MessageBox.Show("Loi");

            }
        }
    }
}
