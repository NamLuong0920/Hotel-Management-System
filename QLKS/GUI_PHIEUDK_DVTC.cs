using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKS;
using BUS_QLKS;

namespace QLKS
{
    public partial class GUI_PHIEUDK_DVTC : Form
    {
        BUS_PHIEUDANGKI_DVTC pdk_dvtc = new BUS_PHIEUDANGKI_DVTC();
        BUS_DICHVUHOPTAC dvht = new BUS_DICHVUHOPTAC();

        public GUI_PHIEUDK_DVTC(string MADVTC, string tenDV, string PhiTamThoi, string Gia, string phong)
        {
            InitializeComponent();

            txtMaDV.Text = MADVTC;
            txtTenDV.Text = tenDV;
            txtPhiTamThoi.Text = PhiTamThoi;
            txtGia.Text = Gia;
            txtPhong.Text = phong;


            dgvPNP.DataSource = dvht.getPNP();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            new GUI_DVTC().Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //txtMaDV.Text = maDV;
            //txtTenDV.Text = tenDV;
            //txtDonViTinh.Text = donViTinh;
            //txtGia.Text = Gia;
            //txtPhong.Text = phong;

            if (txtMaPNP.Text != "" && txtMaDV.Text != "" && txtGia.Text != "" && txtPhong.Text != "" && txtPhiTamThoi.Text != ""
                && txtTenDV.Text != "")
            {


                // Them
                try
                {
                    pdk_dvtc.themPDK_DVTC(txtMaDV.Text, txtMaPNP.Text, DateTime.Parse(dtpThoiDiemDangKy.Text), DateTime.Parse(dtpThoiDiemSuDung.Text));
                    MessageBox.Show("Đăng ký thành công");
                    MessageBox.Show("Bạn cần phải thanh toán" + " " + txtPhiTamThoi.Text + " " + "để được sử dụng dịch vụ");
                    this.Hide();
                    new GUI_DVTC().Show();
                }
                catch
                {
                    MessageBox.Show("Đăng ký không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void dgvPNP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
             GUI_DVTC DVTC = new GUI_DVTC();
             DVTC.Show();
            this.Hide();

        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {

            if (txtMaPNP.Text != "" && txtMaDV.Text != "" && txtGia.Text != "" && txtPhong.Text != "" && txtPhiTamThoi.Text != ""
                && txtTenDV.Text != "")
            {


                // Them
                try
                {
                    pdk_dvtc.themPDK_DVTC(txtMaDV.Text, txtMaPNP.Text, DateTime.Parse(dtpThoiDiemDangKy.Text), DateTime.Parse(dtpThoiDiemSuDung.Text));
                    MessageBox.Show("Đăng ký thành công");
                    MessageBox.Show("Bạn cần phải thanh toán" + " " + txtPhiTamThoi.Text + " " + "để được sử dụng dịch vụ");
                    this.Hide();
                    new GUI_DVTC().Show();
                }
                catch
                {
                    MessageBox.Show("Đăng ký không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
