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
    public partial class GUI_CHECKIN_DICHVU : Form
    {
        public static string madp;
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        public GUI_CHECKIN_DICHVU()
        {
            InitializeComponent();
        }
        public GUI_CHECKIN_DICHVU(string MADP)
        {
            InitializeComponent();
            madp = MADP;
            //dsDichVu.DataSource = busPDP.layThongTinDVHoTro(madp);
        }
        private void GUI_CHECKIN_DICHVU_Load(object sender, EventArgs e)
        {
            //dsDichVu.DataSource = busPDP.layThongTinDVHoTro(madp);

        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_CHECKIN checkinFORM = new GUI_CHECKIN();
            checkinFORM.Show();
        }

        private void dsDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_CHECKIN_DICHVU_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busPDP.layThongTinDVHoTro(madp);
        }
    }
}
