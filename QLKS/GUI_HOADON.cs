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
    public partial class GUI_HOADON : Form
    {
        private int mp;
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        BUS_PHONG busPhong = new BUS_PHONG();
        BUS_HOADON busHoaDon = new BUS_HOADON();
        BUS_KHACHHANG busKH = new BUS_KHACHHANG();
        public GUI_HOADON(int mp)
        {
            InitializeComponent();
            this.mp = mp;
            int MaNguoiDat = busPDP.layNGUOIDAT(mp);
            lbMaKH.Text = MaNguoiDat.ToString();
            DateTime currentDate = busHoaDon.getCurrentDate();
            lbThoiDiem.Text = currentDate.ToString();
            string hotenKH = busKH.layHoTenKH(MaNguoiDat);
            lbHoTenKH.Text = hotenKH.ToString();
            decimal tienPhong = busHoaDon.tinhTienPhong(MaNguoiDat);
            lbTienPhong.Text = tienPhong.ToString();
            decimal tienCSVC = busHoaDon.tinhTienCSVC(MaNguoiDat);
            lbTienCSVC.Text = tienCSVC.ToString();
            decimal tienDV = busHoaDon.tinhTienDV(MaNguoiDat);
            lbTienDV.Text = tienDV.ToString();
            decimal tienCoc = busHoaDon.tinhTienCoc(MaNguoiDat);
            lbTienCoc.Text = tienCoc.ToString();
            decimal tongTien = tienPhong + tienCSVC + tienDV - tienCoc;
            lbTongTien.Text = tongTien.ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (rdoTienMat.Checked == true)
            {
                GUI_DANHGIAPHANHOI guiDANHGIAPHANHOI = new GUI_DANHGIAPHANHOI(mp);
                guiDANHGIAPHANHOI.Show();
                this.Hide();
            }
            else if (rdoChuyenKhoan.Checked == true)
            {
                GUI_HOADON_TTCHUYENKHOAN guiTTCHUYENKHOAN = new GUI_HOADON_TTCHUYENKHOAN(mp);
                guiTTCHUYENKHOAN.Show();
                this.Hide();
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_CHECKOUT_XEMTTPHONG gUI_CHECKOUT_XEMTTPHONG = new GUI_CHECKOUT_XEMTTPHONG(mp);
            gUI_CHECKOUT_XEMTTPHONG.Show();
            this.Hide();
        }
    }
}
