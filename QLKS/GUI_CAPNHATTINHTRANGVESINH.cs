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
using System.Xml.Linq;

namespace QLKS
{
    public partial class GUI_CAPNHATTINHTRANGVESINH : Form
    {
        BUS_PHONG busPHG = new BUS_PHONG();
        public GUI_CAPNHATTINHTRANGVESINH()
        {
            InitializeComponent();
        }
        public GUI_CAPNHATTINHTRANGVESINH(string soPhong, string tinhTrangVeSinhHienTai)
        {
            InitializeComponent();
            txtSoPhong.Text = soPhong;
            if(tinhTrangVeSinhHienTai== "ĐÃ VỆ SINH")
            {
                rdbtn_DaDonVeSinh.Checked= true;
            }
            else
            {
                rdbtn_ChuaDonVeSinh.Checked= true;
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_TRANGCHUBUONGPHONG TRANGCHUBUONGPHONGFORM = new GUI_TRANGCHUBUONGPHONG();
            TRANGCHUBUONGPHONGFORM.Show();
        }

        private void GUI_CAPNHATTINHTRANGVESINH_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_ChuaDonVeSinh.Checked == true)
                {
                    busPHG.capNhatVeSinhPHONG(txtSoPhong.Text, "CHƯA VỆ SINH");
                }
                else
                {
                    busPHG.capNhatVeSinhPHONG(txtSoPhong.Text, "ĐÃ VỆ SINH");
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
                GUI_TRANGCHUBUONGPHONG TRANGCHUBUONGPHONGFORM = new GUI_TRANGCHUBUONGPHONG();
                TRANGCHUBUONGPHONGFORM.Show();
            }
        }
    }
}
