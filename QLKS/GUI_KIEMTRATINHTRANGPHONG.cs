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
    public partial class GUI_KIEMTRATINHTRANGPHONG : Form
    {
        BUS_PHONG busPHG = new BUS_PHONG();
        BUS_PHIEUNHANPHONG busPNP = new BUS_PHIEUNHANPHONG();
        public GUI_KIEMTRATINHTRANGPHONG()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_TRANGCHULETAN TRANGCHULETANFORM = new GUI_TRANGCHULETAN();
            TRANGCHULETANFORM.Show();
        }

        private void GUI_KIEMTRATINHTRANGPHONG_Load(object sender, EventArgs e)
        {
            DataGridView dt = new DataGridView();
            dt.DataSource = busPHG.getPHONG();

            cbbSoPhong.DataSource = dt.DataSource;
            cbbSoPhong.DisplayMember = "MAPHONG";

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            bool check = false;
            MessageBox.Show(dtpTuNgay.Value.ToString("yyyy/MM/dd"),"TỪ NGÀY");
            MessageBox.Show(dtpDenNgay.Value.ToString("yyyy/MM/dd"),"ĐẾN NGÀY");
            check =  busPNP.kiemTraTinhTrangPhong(cbbSoPhong.Text, dtpTuNgay.Value.ToString("yyyy/MM/dd"), dtpDenNgay.Value.ToString("yyyy/MM/dd"));
            if(check)
            {
                txtKetQuaKiemTra.Text = "KHÔNG TRỐNG";
            }
            else
            {
                txtKetQuaKiemTra.Text = "CÒN TRỐNG";
            }
        }

    }
}
