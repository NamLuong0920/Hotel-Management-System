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
    public partial class GUI_DANHGIAPHANHOI : Form
    {
        private int mp;
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();

        public GUI_DANHGIAPHANHOI(int mp)
        {
            InitializeComponent();
            this.mp = mp;
            int MaNguoiDat = busPDP.layNGUOIDAT(mp);
            lbMAKH.Text = MaNguoiDat.ToString();
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {

        }
    }
}
