using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLKS;
using DTO_QLKS;

namespace QLKS
{
  
    public partial class GUI_CHECKOUT_XEMTTPHONG : Form
    {
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        BUS_PHONG busPhong = new BUS_PHONG();
        private int mp;
        public GUI_CHECKOUT_XEMTTPHONG(int mp)
        {
            InitializeComponent();
            this.mp = mp;
            int MaNguoiDat = busPDP.layNGUOIDAT(mp);
            lbMaKH.Text = MaNguoiDat.ToString();
            DataTable dtDSPhong = busPhong.getDSPhong_MaNguoiDat(MaNguoiDat);
            dsPhong.DataSource = dtDSPhong;
            DataTable dtHHDSPhong = busPhong.getHongHoc_DSPhong_MaNguoiDat(MaNguoiDat);
            dsTinhTrangPhong.DataSource = dtHHDSPhong;
            DataTable dtDVDSPhong = busPhong.getDichVu_DSPhong_MaNguoiDat(MaNguoiDat);
            dsDVPhong.DataSource = dtDVDSPhong;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            GUI_HOADON guiHoaDon = new GUI_HOADON(mp);
            guiHoaDon.Show();
            this.Hide();
        }

        private void lbMaKH_Click(object sender, EventArgs e)
        {

        }

        private void dsPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsTinhTrangPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsDVPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_PHIEUTRAPHONG gUI_PHIEUTRAPHONG = new GUI_PHIEUTRAPHONG();
            gUI_PHIEUTRAPHONG.Show();
            this.Hide();
        }
    }
}
