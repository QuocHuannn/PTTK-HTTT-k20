using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTT
{
    public partial class iSignUp : Form
    {
        public iSignUp()
        {
            InitializeComponent();
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
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            textBox2.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            textBox3.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            textBox4.BackColor = SystemColors.Control;
            panel6.BackColor = SystemColors.Control;
        }
        private void password_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox3.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            textBox4.BackColor = SystemColors.Control;
            panel6.BackColor = SystemColors.Control;
        }
        private void name_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            textBox3.BackColor = Color.White;
            panel5.BackColor = Color.White;
            textBox4.BackColor = SystemColors.Control;
            panel6.BackColor = SystemColors.Control;
        }
        private void phone_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            textBox3.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            textBox4.BackColor = Color.White;
            panel6.BackColor = Color.White;
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
                this.WindowState = FormWindowState.Normal; if (WindowState == FormWindowState.Normal)
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
