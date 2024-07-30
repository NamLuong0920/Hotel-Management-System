using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKS;
using BUS_QLKS;

namespace QLKS
{
    public partial class GUI_PHIEUDATPHONG : Form
    {
        public int daily=0;  // tam de la 0
        public string ngayden = "";
        public string ngaydi = "";
        public string hinhthuc = "";
        public int loaiphong = 0;
        public string loaikhach = "";
        public string hangphong = "";
        public int sophong = 0;
        public string nvletan = "";
        public int sotientamtinh;
        public int sotientratruoc;
        public string yeucau = "";
        public int songuoi = 0;
        public string ngaydat = "";
        public int choice;
        public int MaKH = 0;
        public int MaPDP = 0;
        BUS_PHIEUDATPHONG buspdp = new BUS_PHIEUDATPHONG();
        BUS_PHONG busphong = new BUS_PHONG();
        BUS_KHACHHANG buskh = new BUS_KHACHHANG();
        BUS_PHIEUNHANPHONG busPhieuNhanPhong = new BUS_PHIEUNHANPHONG();

        public GUI_PHIEUDATPHONG()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void YeuCauKhac_checkedboxlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLapPhieuDP_Click(object sender, EventArgs e)
        {
            if (comboxDaiLy.Enabled == true)
            {
                if (comboxDaiLy.SelectedItem.ToString() == "BOOK")
                {
                    daily = 1;
                }
                else if (comboxDaiLy.SelectedItem.ToString() == "TRAVELOKA")
                {
                    daily = 2;
                }
                else if (comboxDaiLy.SelectedItem.ToString() == "THINHNGOTOURIST")
                {
                    daily = 3;
                }
            }
            ngaydat = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            ngayden = ngayBatDau.Value.Date.ToString("yyyy-MM-dd");
            ngaydi = ngayDi.Value.Date.ToString("yyyy-MM-dd");
            hinhthuc = ComboBox_hinhthuc.SelectedItem.ToString();
            MaKH = buskh.getKH_hientai();
            sophong = Convert.ToInt32(countSoPhong.Value);
            //Ghi tong tin phhieu dat phong 
            for (int i = 0; i < YeuCauKhac_checkedboxlist.Items.Count; i++)
            {
                if (YeuCauKhac_checkedboxlist.GetItemChecked(i))
                {
                    yeucau += YeuCauKhac_checkedboxlist.Items[i].ToString() + ", ";
                }
            }
            if (yeucau.Length > 0)
            {
                yeucau = yeucau.Substring(0, yeucau.Length - 2);
            }
            /*if(ComboBox_hinhthuc.Text!=null && comboBox_LoaiKhach.Text != null && comboBox_LoaiPhong.Text!=null && comboHangPhong!=null&& ngayBatDau.Value!=null && ngayDi.Value != null && daily!=null)
            {
*//*               DTO_PHIEUDATPHONG phieudatphong= new DTO_PHIEUDATPHONG(0,null,,ngayBatDau.);
*//*            }*/
            if(yeucau==" ") { yeucau = null; }
            DTO_PHIEUDATPHONG pdp = new DTO_PHIEUDATPHONG(0, daily, MaKH, ngayden, ngaydi, yeucau, hinhthuc, ngaydat, sotientratruoc, sotientamtinh, songuoi, sophong, "Không có");
            if (buspdp.themPDP(pdp))
            {
                MessageBox.Show("Đã thêm phiếu đặt phòng");
                btnChonPhong.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loi");

            }


        }

        private void GUI_PHIEUDATPHONG_Load(object sender, EventArgs e)
        {
           
            comboxDaiLy.Enabled = false;
            btnChonPhong.Enabled = false;
            btnLapPhieuDP.Enabled = false;
        }

        private void ComboBox_hinhthuc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBox_hinhthuc.SelectedItem.ToString() == "ĐẠI LÝ")
            {
                comboxDaiLy.Enabled = true ;
            }
          
        }

        private void btnDienThongTinKH_Click(object sender, EventArgs e)
        {
            GUI_PHIEUDIENTHONGTINKHACHHANG gui_phieukhachhang = new GUI_PHIEUDIENTHONGTINKHACHHANG();
            gui_phieukhachhang.ShowDialog();
            btnLapPhieuDP.Enabled = true;

        }

        private void comboxDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_LoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaikhach = comboBox_LoaiKhach.SelectedItem.ToString();
        }

        private void comboBox_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if(comboBox_LoaiPhong.SelectedItem.ToString()=="Single")
            {
                loaiphong = 1;
            }
            if (comboBox_LoaiPhong.SelectedItem.ToString() == "Twin")
            {
                loaiphong = 3;
            }
                if (comboBox_LoaiPhong.SelectedItem.ToString() == "Double")
            {
                loaiphong = 5;
            }*/

     

            this.comboHangPhong.Enabled = true;
        }


        private void comboHangPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void ngayBatDau_ValueChanged(object sender, EventArgs e)
        {


        }

        private void ngayDi_ValueChanged(object sender, EventArgs e)
        {
        }

        private void countSoPhong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            MaPDP = buspdp.getMADP_hientai();
            DTO_PHIEUNHANPHONG pnp = new DTO_PHIEUNHANPHONG(MaKH,MaPDP,MaKH ,"null", choice, 1);
           if( busPhieuNhanPhong.themPNP(pnp))
            {
                MessageBox.Show("Thêm Phiếu Nhận Phòng Thành Công ");
            }    
           else
            {
                MessageBox.Show("Thêm Phiếu Nhận Phòng Thất bại ");

            }



        }

        private void DSPHONG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            



            if (comboBox_LoaiPhong.SelectedItem.ToString() == "Single")
            {
                loaiphong = 1;
            }
            else if (comboBox_LoaiPhong.SelectedItem.ToString() == "Twin")
            {
                loaiphong = 3;
            }
            else  if (comboBox_LoaiPhong.SelectedItem.ToString() == "Double")
            {
                loaiphong = 5;
            }
            if (comboHangPhong.SelectedItem.ToString() == "VIP")
            { loaiphong += 1; } 
                 MessageBox.Show(loaiphong.ToString());
                DSPHONG.DataSource = busphong.checkPhong("CÒN TRỐNG", "ĐÃ VỆ SINH", loaiphong);
            
            


        }

        private void DSPHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            choice = Convert.ToInt32(DSPHONG.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show(choice.ToString());


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void sotienTraTruocLabel_Click(object sender, EventArgs e)
        {

        }

        private void sotientamtinhLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_TRANGCHULETAN gUI_TRANGCHULETAN = new GUI_TRANGCHULETAN();
            gUI_TRANGCHULETAN.Show();
            this.Hide();
        }
    }
}
