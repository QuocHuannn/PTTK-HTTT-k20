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
using System.Xml.Linq;

namespace PTTKHTTT
{
    public partial class iSignUp : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public iSignUp()
        {
            
            InitializeComponent();
            //_connectionString = @"Data Source=LAPTOP-V9EI97MS\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            _connectionString = @"Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        */
        private void username_Click(object sender, EventArgs e)
        {
            UserName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            PassWord.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            rePassWord.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            
        }
        private void password_Click(object sender, EventArgs e)
        {
            UserName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            PassWord.BackColor = Color.White;
            panel4.BackColor = Color.White;
            rePassWord.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
           
        }
        private void name_Click(object sender, EventArgs e)
        {
            UserName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            PassWord.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            rePassWord.BackColor = Color.White;
            panel5.BackColor = Color.White;
            
        }
        private void phone_Click(object sender, EventArgs e)
        {
            UserName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            PassWord.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            rePassWord.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
           
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backSignIn_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            iSignIn dangNhap = new iSignIn();
            dangNhap.Show();
        }

        private void valiSignUp_Btn_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-V9EI97MS\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True;");
            SqlConnection connection = new SqlConnection("Data Source=ANHNHANDEPTRAI;Initial Catalog=QLKhachSan;Integrated Security=True;");
            connection.Open();
            string uName=UserName.Text;
            string uPass=PassWord.Text;
            string rePass=rePassWord.Text;
            SqlCommand sql = new SqlCommand("RegisterAccount", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@p_Username", SqlDbType.VarChar).Value = uName;
            sql.Parameters.AddWithValue("@p_Pass", SqlDbType.VarChar).Value = uPass;
            sql.Parameters.AddWithValue("@p_ConfirmPass", SqlDbType.VarChar).Value = rePass;
            try
            {
                SqlDataReader reader = sql.ExecuteReader();
                MessageBox.Show("Dang Ky Thanh Cong");


            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
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
