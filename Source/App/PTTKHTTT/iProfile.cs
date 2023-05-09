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
    public partial class iProfile : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public iProfile()
        {
            InitializeComponent();
            _connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            string sql = @"select HoTen from KhachHang where KhachHang.HoTen = N'Nguyễn Văn A'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, _connection);
            //SqlDataAdapter adapt2 = new SqlDataAdapter(sql2, _connection);
            DataSet dts = new DataSet();
            //DataSet dts2 = new DataSet();
            adapt.Fill(dts);
            userName.DataSource = dts;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
