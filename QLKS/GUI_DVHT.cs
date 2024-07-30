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
    public partial class GUI_DVHT : Form
    {
        BUS_DICHVUHOPTAC DVHT = new BUS_DICHVUHOPTAC();

        public GUI_DVHT()
        {
            InitializeComponent();
        }

        private void LoadDVHT()
        {
            dgvDVHT.DataSource = DVHT.getDVHT();


           /* // Đặt tên cột
            dgvDVHT.Columns["MADVHT"].HeaderText = "Mã DVHT";
            dgvDVHT.Columns["MADOITACDV"].HeaderText = "Mã đối tác DV";
            dgvDVHT.Columns["TENDV"].HeaderText = "Tên DV";
            dgvDVHT.Columns["GIA"].HeaderText = "Giá";*/
        }

        private void GUI_DVHT_Load(object sender, EventArgs e)
        {
        }

        private void dgvDVHT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void GUI_DVHT_Load_1(object sender, EventArgs e)
        {
            LoadDVHT();


        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            GUI_TRANGCHULETAN mainLETAN = new GUI_TRANGCHULETAN();
            mainLETAN.Show();
            this.Hide();
        }

        private void dgvDVHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDV = "";
            string tenDV = "";
            string maDT = "";
            string Gia = "";
            if (e.RowIndex >= 0)
            {

                maDV = dgvDVHT.Rows[e.RowIndex].Cells["MADVHT"].Value.ToString();
                tenDV = dgvDVHT.Rows[e.RowIndex].Cells["TENDV"].Value.ToString();
                maDT = dgvDVHT.Rows[e.RowIndex].Cells["MADOITACDV"].Value.ToString();
                Gia = dgvDVHT.Rows[e.RowIndex].Cells["GIA"].Value.ToString();

                this.Hide();
                GUI_PHIEUDK_DVHT phieudk_dvht = new GUI_PHIEUDK_DVHT(maDV, tenDV, maDT, Gia);
                phieudk_dvht.Show();
            }
        }
    }
}
