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
    public partial class GUI_CAPNHATTINHTRANGDUYET_GIAHAN : Form
    {
        BUS_GIAHAN busGH = new BUS_GIAHAN();
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        public GUI_CAPNHATTINHTRANGDUYET_GIAHAN()
        {
            InitializeComponent();
        }
        public GUI_CAPNHATTINHTRANGDUYET_GIAHAN(string maGH, string tinhTrangDuyetHienTai)
        {
            InitializeComponent();
            txtMaGH.Text = maGH;
            if(tinhTrangDuyetHienTai == "CHƯA DUYỆT")
            {
                rdbtn_ChuaDuyet.Checked = true;
            }
            else if(tinhTrangDuyetHienTai == "ĐÃ DUYỆT")
            {
                rdbtn_DaDuyet.Checked = true;
            }
            else
            {
                rdbtn_TuChoi.Checked = true;
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_XEMDSGIAHANPHONG XEMDSGIAHANPHONGFORM = new GUI_XEMDSGIAHANPHONG();
            XEMDSGIAHANPHONGFORM.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_ChuaDuyet.Checked == true)
                {
                    busGH.capNhatTinhTrangDuyet(txtMaGH.Text, "CHƯA DUYỆT");
                }
                else if(rdbtn_DaDuyet.Checked == true)
                {
                    busGH.capNhatTinhTrangDuyet(txtMaGH.Text, "ĐÃ DUYỆT");
                    busPDP.capNhatTinhTrangDuyet(txtMaGH.Text);
                }
                else if (rdbtn_TuChoi.Checked == true)
                {
                    busGH.capNhatTinhTrangDuyet(txtMaGH.Text, "TỪ CHỐI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể cập nhật", "Thông báo");
            }
            finally
            {
                MessageBox.Show("Đã cập nhật thành công!");
                this.Hide();
                GUI_XEMDSGIAHANPHONG XEMDSGIAHANPHONGFORM = new GUI_XEMDSGIAHANPHONG();
                XEMDSGIAHANPHONGFORM.Show();
            }
        }

        private void GUI_CAPNHATTINHTRANGDUYET_GIAHAN_Load(object sender, EventArgs e)
        {

        }
    }
}
