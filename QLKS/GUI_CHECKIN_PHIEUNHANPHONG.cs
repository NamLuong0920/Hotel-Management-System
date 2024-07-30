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
    public partial class GUI_CHECKIN_PHIEUNHANPHONG : Form
    {
        public static string madp;
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        BUS_PHIEUNHANPHONG busPNP = new BUS_PHIEUNHANPHONG();
        BUS_KHACHHANG buskh = new BUS_KHACHHANG();
        public GUI_CHECKIN_PHIEUNHANPHONG()
        {
            InitializeComponent();
        }
        public GUI_CHECKIN_PHIEUNHANPHONG(string MADP)
        {
            InitializeComponent();
            madp= MADP;
            
        }
        private void GUI_CHECKIN_PHIEUNHANPHONG_Load(object sender, EventArgs e)
        {
            //nguoiDat.DataSource = busPDP.layDSPhong(madp);

        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_CHECKIN TRANGCHULETANFORM = new GUI_CHECKIN();
            TRANGCHULETANFORM.Show();
        }

        private void GUI_CHECKIN_PHIEUNHANPHONG_Load_1(object sender, EventArgs e)
        {
            dsPhong.DataSource = busPDP.layDSPhong(madp);
            //if (buskh.dsKhachNhanPhong(madp).Rows.Count > 0)
            //{
            //    dsnguoinhan.DataSource = buskh.dsKhachNhanPhong(madp);
            //}
            //dsnguoinhan.DataSource = busPDP.layDSPhong(madp);

        }

        private void dsPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu bấm vào một dòng hợp lệ
            {
                DataGridViewRow row = dsPhong.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng đã bấm vào
                string rowData1 = row.Cells["MAPNP"].Value.ToString(); // Thay "Column1" bằng tên cột thực tế
                string rowData2 = row.Cells["MAPHONG"].Value.ToString();
                // ...

                // Hiển thị màn hình mới và chuyển dữ liệu qua màn hình mới
                GUI_CHECKIN_THEMPHIEUNHANPHONG formMoi = new GUI_CHECKIN_THEMPHIEUNHANPHONG(rowData1, rowData2, madp);
                formMoi.ShowDialog();
            }
        }
    }
}
