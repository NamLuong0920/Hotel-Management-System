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
    public partial class GUI_LAPPHIEUGIAHANPHONG : Form
    {
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        BUS_GIAHAN busGH = new BUS_GIAHAN();
        public GUI_LAPPHIEUGIAHANPHONG()
        {
            InitializeComponent();
        }

        private void GUI_LAPPHIEUGIAHANPHONG_Load(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.DataSource = busPDP.getPDP_HienTai();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cbbMaPDP.DataSource = dataGridView1.DataSource;
            cbbMaPDP.DisplayMember = "MADP";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_GIAHANPHONG GIAHANPHONGFORM = new GUI_GIAHANPHONG();
            GIAHANPHONGFORM.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int soNgayGiaHan;
            if (txtSoNgayGiaHan.Text == "" ) {
                MessageBox.Show("Số ngày gia hạn không được để trống!");
            }
            else if(int.TryParse(txtSoNgayGiaHan.Text, out soNgayGiaHan)!=true)
            {
                MessageBox.Show("SỐ NGÀY GIA HẠN PHẢI LÀ SỐ NGUYÊN!");
            }
            else
            {
                try
                {
                    //Load thông tin của Phiếu đặt phòng cần gia hạn
                    busGH.themGIAHAN(cbbMaPDP.Text, soNgayGiaHan);
                    MessageBox.Show("LẬP THÀNH CÔNG PHIẾU GIA HẠN PHÒNG!", "Thông báo");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
