using BUS_QLKS;
using DTO_QLKS;
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
    public partial class GUI_PHIEUTRAPHONG : Form
    {
        BUS_PHIEUTRAPHONG busPTP = new BUS_PHIEUTRAPHONG();
        public GUI_PHIEUTRAPHONG()
        {
            InitializeComponent();
        }

        private void GUI_PHIEUTRAPHONG_Load(object sender, EventArgs e)
        {

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int mp = Int32.Parse(txtMaPhong.Text);
            GUI_CHECKOUT_XEMTTPHONG guiXemttphong = new GUI_CHECKOUT_XEMTTPHONG(mp);
            guiXemttphong.Show();
            this.Hide();
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_TRANGCHULETAN gUI_TRANGCHULETAN = new GUI_TRANGCHULETAN();
            gUI_TRANGCHULETAN.Show();
            this.Hide();
        }
    }
}
