using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTTKHTTT
{
    public partial class ThayDoiTT : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public ThayDoiTT()
        {

            InitializeComponent();
            _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            //_connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-V9EI97MS\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True;");
            SqlConnection connection = new SqlConnection("Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True;");
            connection.Open();
            string name = txtName.Text;
            string SoDT = txtSdt.Text;
            string CM = txtCMND.Text;
            string add = txtAddress.Text;
            string Gen = txtGender.Text;
            //string query = "select ID from KhachHang,Account where  AccountID  = ID";
            // SqlCommand sql = new SqlCommand ("exec UpdateKhachHang  " + " @MaKH  =" + query + "," + " @HoTen =N'" + name + "'" + "," + "@Sdt=N'" + SoDT + "'" + "," + "@CMND=N'" + CM + "'" + "," + "@GioiTinh=N'" + Gen + "'" + "," + "@DiaChi=N'" + add + "'", connection);
            SqlCommand sql = new SqlCommand("UpdateKhachHang", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@MaKH", SqlDbType.Int).Value = 1;
            sql.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = name;
            sql.Parameters.AddWithValue("@Sdt", SqlDbType.NVarChar).Value = SoDT;
            sql.Parameters.AddWithValue("@CMND", SqlDbType.NVarChar).Value = CM;
            sql.Parameters.AddWithValue("@GioiTinh", SqlDbType.NVarChar).Value = Gen;
            sql.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = add;
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

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
