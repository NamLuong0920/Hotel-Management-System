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
    public partial class GUI_CHECKIN_THEMPHIEUNHANPHONG : Form
    {
        public static string madp;
        public static string mapnp;
        public static string maphong;
        public static string manv;
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        BUS_PHIEUNHANPHONG busPNP = new BUS_PHIEUNHANPHONG();
        BUS_KHACHHANG busKH = new BUS_KHACHHANG();
        BUS_TAIKHOAN busTK = new BUS_TAIKHOAN();
        public GUI_CHECKIN_THEMPHIEUNHANPHONG()
        {
            InitializeComponent();
        }
        public GUI_CHECKIN_THEMPHIEUNHANPHONG(string MAPNP, string MAPHONG,string MADP)
        {
            InitializeComponent();
            madp = MADP;
            mapnp = MAPNP;
            maphong= MAPHONG;
        }
        private void GUI_CHECKIN_THEMPHIEUNHANPHONG_Load(object sender, EventArgs e)
        {
            txtPHONG.Text = maphong;
            txtPHONG.Enabled = false;
            btnXacNhan.Enabled = false;
            if (TXtCCCD.Text!=""&& txtTEN.Text != "" && txtSODIENTHOAI.Text != "" &&
                txtEMAIL.Text != "" && txtDIACHI.Text != "" && txtQUOCTICH.Text != "")
            {
                btnXacNhan.Enabled = true;
            }
                
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_CHECKIN_PHIEUNHANPHONG CHECKINFORM = new GUI_CHECKIN_PHIEUNHANPHONG();
            CHECKINFORM.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //busKH.themKhachNhanPhong(madp,mapnp, TXtCCCD.Text, txtTEN.Text, txtSODIENTHOAI.Text, txtEMAIL.Text, txtDIACHI.Text, txtQUOCTICH.Text);
            this.Hide();
            GUI_CHECKIN_PHIEUNHANPHONG TRANGCHULETANFORM = new GUI_CHECKIN_PHIEUNHANPHONG();
            TRANGCHULETANFORM.Show();

        }
    }
}
