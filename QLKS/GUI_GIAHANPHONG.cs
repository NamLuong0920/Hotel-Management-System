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
    public partial class GUI_GIAHANPHONG : Form
    {
        public GUI_GIAHANPHONG()
        {
            InitializeComponent();
        }

        private void GUI_GIAHANPHONG_Load(object sender, EventArgs e)
        {

        }

        private void btnXemDSGiaHanPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_XEMDSGIAHANPHONG XEMDSGIAHANPHONGFORM = new GUI_XEMDSGIAHANPHONG();
            XEMDSGIAHANPHONGFORM.Show();
        }

        private void btnLapPhieuGiaHanPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_LAPPHIEUGIAHANPHONG LAPPHIEUGIAHANPHONGFORM = new GUI_LAPPHIEUGIAHANPHONG();
            LAPPHIEUGIAHANPHONGFORM.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_TRANGCHULETAN TRANGCHULETANFORM = new GUI_TRANGCHULETAN();
            TRANGCHULETANFORM.Show();
        }
    }
}
