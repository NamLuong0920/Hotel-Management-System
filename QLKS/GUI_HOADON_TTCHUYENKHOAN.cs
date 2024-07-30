using BUS_QLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class GUI_HOADON_TTCHUYENKHOAN : Form
    {
        private int mp;
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        public GUI_HOADON_TTCHUYENKHOAN(int mp)
        {
            InitializeComponent();
            this.mp = mp;
            int MaNguoiDat = busPDP.layNGUOIDAT(mp);
            lbMaKH.Text = MaNguoiDat.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_DANHGIAPHANHOI guiDANHGIAPHANHOI = new GUI_DANHGIAPHANHOI(mp);
            guiDANHGIAPHANHOI.Show();
            this.Hide();
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_HOADON gUI_HOADON = new GUI_HOADON(mp);
            gUI_HOADON.Show();
            this.Hide();
        }
    }
}
