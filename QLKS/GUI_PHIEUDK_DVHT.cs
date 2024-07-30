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
    public partial class GUI_PHIEUDK_DVHT : Form
    {

        BUS_PHIEUDANGKI_DVHT bus = new BUS_PHIEUDANGKI_DVHT();
        BUS_PHIEUDATPHONG pdp = new BUS_PHIEUDATPHONG();


        public GUI_PHIEUDK_DVHT(string MADVHT, string tenDV, string maDT, string Gia)
        {
            InitializeComponent();

            txtMaDV.Text = MADVHT;
            txtTenDV.Text = tenDV;
            txtDoiTac.Text = maDT;
            txtGia.Text = Gia;

            //txtMaPDP.Text = select ;

            dgvPDP.DataSource = pdp.getPDP();

        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            new GUI_DVHT().Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMaPDP.Text != "" && txtSoNguoi.Text != "" && txtDoiTac.Text != "" && txtTenDV.Text != "" &&
                txtTenKhachHang.Text != "" && txtMaDV.Text != "" && cbbCachThucDiChuyen.Text != "" &&
                cbbTinhTrangDuyet.Text != "" && dtpThoiGianKetThuc.Text != "" && dtpThoiGianKetThuc.Text != "")
            {
                try
                {
                    bus.themPDK_DVHT(txtMaPDP.Text, txtMaDV.Text, txtSoNguoi.Text, DateTime.Parse(dtpThoiGianKhoiHanh.Text), cbbCachThucDiChuyen.Text, cbbTinhTrangDuyet.Text,
                    DateTime.Parse(dtpThoiGianKetThuc.Text));

                    if (DialogResult.OK ==
                    MessageBox.Show(
                        "Thông tin của bạn đã được gửi đến đối tác dịch vụ. Bạn cần chờ thông báo để được sử dụng.",
                        "Thông báo!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question))
                    {
                        this.Hide();
                        new GUI_DVHT().Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Thông tin gửi đi không thành công!!!");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }

        }

        private void dgvPDP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPDP = "";
            string tenKH = "";
            if (e.RowIndex >= 0)
            {

                maPDP = dgvPDP.Rows[e.RowIndex].Cells["MADP"].Value.ToString();
                tenKH = dgvPDP.Rows[e.RowIndex].Cells["NGUOIDAT"].Value.ToString();

                txtMaPDP.Text = maPDP;
                txtTenKhachHang.Text = tenKH;
            }
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (txtMaPDP.Text != "" && txtSoNguoi.Text != "" && txtDoiTac.Text != "" && txtTenDV.Text != "" &&
                txtTenKhachHang.Text != "" && txtMaDV.Text != "" && cbbCachThucDiChuyen.Text != "" &&
                cbbTinhTrangDuyet.Text != "" && dtpThoiGianKetThuc.Text != "" && dtpThoiGianKetThuc.Text != "")
            {
                try
                {
                    bus.themPDK_DVHT(txtMaPDP.Text, txtMaDV.Text, txtSoNguoi.Text, DateTime.Parse(dtpThoiGianKhoiHanh.Text), cbbCachThucDiChuyen.Text, cbbTinhTrangDuyet.Text,
                    DateTime.Parse(dtpThoiGianKetThuc.Text));

                    if (DialogResult.OK ==
                    MessageBox.Show(
                        "Thông tin của bạn đã được gửi đến đối tác dịch vụ. Bạn cần chờ thông báo để được sử dụng.",
                        "Thông báo!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question))
                    {
                        this.Hide();
                        new GUI_DVHT().Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Thông tin gửi đi không thành công!!!");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
