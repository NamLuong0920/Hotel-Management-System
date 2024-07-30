using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLKS;

namespace QLKS
{
    public partial class GUI_DVTC : Form
    {
        BUS_DV_TAICHO DVTC = new BUS_DV_TAICHO();

        public GUI_DVTC()
        {
            InitializeComponent();
        }

        private void LoadDVTC()
        {

            dgvDVTC.DataSource = DVTC.getDVTC();
            // Đặt tên cột
            /* dgvDVTC.Columns["MADVTC"].HeaderText = "Mã DVTC";
             dgvDVTC.Columns["TENDV"].HeaderText = "Tên DV";
             dgvDVTC.Columns["DONVITINH"].HeaderText = "Đơn vị tính";
             dgvDVTC.Columns["GIA"].HeaderText = "Giá";
             dgvDVTC.Columns["PHITAMTHOI"].HeaderText = "Phí tạm thời";*/
        }

        private void GUI_DVTC_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void dgvDVTC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (txtPhong.Text != "")
            {
                string maPhong = txtPhong.Text;

                dgvDVTC.DataSource = DVTC.timKiem_DVTC(maPhong); // refresh datagridview


            }
            else
            {
                MessageBox.Show("Hãy nhập số phòng!!!");
            }
        }

        private void dgvDVTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDV = "";
            string tenDV = "";
            string phiTamThoi = "";
            string Gia = "";
            string phong = "";
            if (e.RowIndex >= 0)
            {

                maDV = dgvDVTC.Rows[e.RowIndex].Cells["MADVTC"].Value.ToString();
                tenDV = dgvDVTC.Rows[e.RowIndex].Cells["TENDV"].Value.ToString();
                Gia = dgvDVTC.Rows[e.RowIndex].Cells["GIA"].Value.ToString();
                phong = txtPhong.Text;

                this.Hide();
                GUI_PHIEUDK_DVTC phieudk_dvtc = new GUI_PHIEUDK_DVTC(maDV, tenDV, phiTamThoi, Gia, phong);
                phieudk_dvtc.Show();
            }
        }

        private void GUI_DVTC_Load_1(object sender, EventArgs e)
        {
            LoadDVTC();
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            GUI_TRANGCHULETAN  mainLETAN= new GUI_TRANGCHULETAN();
            mainLETAN.Show();
            this.Hide();
        }
    }
}