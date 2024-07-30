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
    public partial class GUI_TRANGCHUBELLMAN : Form
    {
        BUS_PHONG busPHG = new BUS_PHONG();
        public GUI_TRANGCHUBELLMAN()
        {
            InitializeComponent();
        }

        private void GUI_TRANGCHUBELLMAN_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busPHG.getPhong_BuongPhong();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cbbSoPhong.DataSource = dataGridView1.DataSource;
            cbbSoPhong.DisplayMember = "MAPHONG";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DANGNHAP DANGNHAPFORM = new GUI_DANGNHAP();
            DANGNHAPFORM.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busPHG.getPhong_BuongPhongTimKiem(cbbSoPhong.Text);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
