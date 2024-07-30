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
    public partial class GUI_TRANGCHUBUONGPHONG : Form
    {
        BUS_PHONG busPHG = new BUS_PHONG();
        public GUI_TRANGCHUBUONGPHONG()
        {
            InitializeComponent();
        }

        private void GUI_TRANGCHUBUONGPHONG_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tinhTrangVeSinhHienTai = "";
            string soPhong = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô được double-click
                tinhTrangVeSinhHienTai = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // Lấy giá trị của ô được double-click
                soPhong = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value.ToString();
            }

            this.Hide();
            GUI_CAPNHATTINHTRANGVESINH CAPNHATTINHTRANGVESINHFORM = new GUI_CAPNHATTINHTRANGVESINH(soPhong, tinhTrangVeSinhHienTai);
            CAPNHATTINHTRANGVESINHFORM.Show();
        }
    }
}
