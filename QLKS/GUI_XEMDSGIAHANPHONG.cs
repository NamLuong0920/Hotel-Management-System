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
    public partial class GUI_XEMDSGIAHANPHONG : Form
    {
        BUS_GIAHAN busGH = new BUS_GIAHAN();
        public GUI_XEMDSGIAHANPHONG()
        {
            InitializeComponent();
        }

        private void GUI_XEMDSGIAHANPHONG_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busGH.getGIAHAN();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cbbSoPhong.DataSource = dataGridView1.DataSource;
            cbbSoPhong.DisplayMember = "MADP";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_GIAHANPHONG GIAHANPHONGFORM = new GUI_GIAHANPHONG();
            GIAHANPHONGFORM.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busGH.getGIAHAN(cbbSoPhong.Text);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tinhTrangDuyetHienTai = "";
            string maGH = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô được double-click
                tinhTrangDuyetHienTai = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // Lấy giá trị của ô được double-click - 3
                maGH = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString();
            }

            this.Hide();
            GUI_CAPNHATTINHTRANGDUYET_GIAHAN CAPNHATTINHTRANGDUYET_GIAHANFORM = new GUI_CAPNHATTINHTRANGDUYET_GIAHAN(maGH, tinhTrangDuyetHienTai);
            CAPNHATTINHTRANGDUYET_GIAHANFORM.Show();
        }
    }
}
