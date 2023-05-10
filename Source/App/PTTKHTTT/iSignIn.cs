using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic.Devices;

namespace PTTKHTTT
{
    public partial class iSignIn : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public iSignIn()
        {
            InitializeComponent();
           //_connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";

        }

        private void iSignIn_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            userName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            passWord.BackColor = SystemColors.Control;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            userName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            passWord.BackColor = Color.White;
        }

        private void logIn_Btn_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-V9EI97MS\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True;");
            SqlConnection connection = new SqlConnection("Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True;");
            connection.Open();
            string usName=userName.Text;
            string pw = passWord.Text;
            SqlCommand sql = new SqlCommand("exec sp_CheckLogin " + " @Username ='" + usName + "'" +","+ " @Pass ='" + pw + "'",connection);
            try
            {
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    this.Hide();
                    iMainUI trangChu = new iMainUI();
                    trangChu.Show();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sai Tài khoản hoặc Mật Khẩu");
                
            }
            
            
          
        }

        private void signIn_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            iSignUp dangKy = new iSignUp();
            dangKy.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
