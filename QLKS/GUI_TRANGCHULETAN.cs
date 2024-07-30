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
    public partial class GUI_TRANGCHULETAN : Form
    {
        public GUI_TRANGCHULETAN()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DANGNHAP DANGNHAPFORM = new GUI_DANGNHAP();
            DANGNHAPFORM.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            GUI_PHIEUDATPHONG DATPHONGFORM = new GUI_PHIEUDATPHONG();
            DATPHONGFORM.Show();
            this.Hide();
          
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
     
        }

     

        private void btnKiemTraTinhTrangPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_KIEMTRATINHTRANGPHONG KIEMTRATINHTRANGPHONGFORM = new GUI_KIEMTRATINHTRANGPHONG();
            KIEMTRATINHTRANGPHONGFORM.Show();
        }

        private void btnDangKyDVTC_Click(object sender, EventArgs e)
        {
            GUI_DVTC DVTCFORM = new GUI_DVTC();
            DVTCFORM.Show();
            this.Hide();
        }

        private void btnDangKyDVHT_Click(object sender, EventArgs e)
        {
            GUI_DVHT guiDichVuHopTac = new GUI_DVHT();
            guiDichVuHopTac.Show();
            this.Hide();
        }

       
        private void btnGiaHanPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_GIAHANPHONG GIAHANPHONGFORM = new GUI_GIAHANPHONG();
            GIAHANPHONGFORM.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            GUI_PHIEUTRAPHONG guiCheckout = new GUI_PHIEUTRAPHONG();
            guiCheckout.Show();
            this.Hide();
        }
    }
}
