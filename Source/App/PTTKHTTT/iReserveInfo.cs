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
    public partial class iReserveInfo : Form
    {
        public iReserveInfo()
        {
            InitializeComponent();
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
    }
}