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
            //_connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backToUI_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iProfile_Load(object sender, EventArgs e)
        {
          //  _connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
            string query = "select HoTen, CMND, Sdt,ID,DiaChi,GioiTinh from KhachHang,Account where  AccountID  = ID";

            var cmd = new SqlCommand(query, _connection);

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var hoTen = reader.GetString("HoTen");
                var cmnd = reader.GetString("CMND");
                var sdt = reader.GetString("Sdt");
                var add = reader.GetString("DiaChi");
                var gen = reader.GetString("GioiTinh");

                txtName.Text = hoTen;
                txtCMND.Text = cmnd;
                txtSdt.Text = sdt;
                txtGen.Text = gen;
                txtAdd.Text = add;
            }
        }

        private void change_Btn_Click(object sender, EventArgs e)
        {
            ThayDoiTT thayDoi = new ThayDoiTT();
            thayDoi.Show();
        }
    }
}
