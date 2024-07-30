using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLKS;
using DTO_QLKS;
namespace QLKS
{
   
    public partial class GUI_PHIEUDIENTHONGTINKHACHHANG : Form
    {
        public string hoten = "";

        public string cmnd = "";

        public string sdt = "";

        public string diachi = "";

        public string  email= "";

        public string quoctich = "";

        public int madoan= 0;

        public int makh = 0;

        public string tendoan = "";

        public int songuoi = 0;

        BUS_KHACHHANG busKhachHang = new BUS_KHACHHANG();
        BUS_DOAN busDoan= new BUS_DOAN();
        public GUI_PHIEUDIENTHONGTINKHACHHANG()
        {
            InitializeComponent();
        }

        private void txtTENKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_PHIEUDIENTHONGTINKHACHHANG_Load(object sender, EventArgs e)
        {

        }

        private void check_doan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLuuKhachHang_Click(object sender, EventArgs e)
        {
            
            // Thêm Khách Hàng vào DS trước 
            hoten = txtTENKH.Text.ToString ();
            cmnd = txtCMND.Text.ToString ();   
            sdt=txtSDT.Text.ToString ();
            diachi = txtAddress.Text.ToString ();
            email = txtEmail.Text.ToString ();
            quoctich=comboQuocTich.SelectedItem.ToString();
       
            //Goi DTO den tao KHACHHANG
            DTO_KHACHHANG kh=new DTO_KHACHHANG(madoan,0,cmnd,hoten,sdt,email,diachi,quoctich);
            if(busKhachHang.themKH(kh))
            {
                MessageBox.Show("Thêm Thành Công Khách Hàng");
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            // Them thong tin doan khach ( ma kh la truong doan )
            if (check_doan.Checked)
            {
                tendoan=txtTenDoan.Text.ToString ();
                makh = busKhachHang.getKH_hientai();
                DTO_DOAN doan = new DTO_DOAN(0, tendoan, makh, songuoi);
                if (busDoan.themDOAN(doan))
                {
                    MessageBox.Show("Thêm đoàn khách thành công!");

                }
                else
                {
                    MessageBox.Show("Chưa thêm được đoàn khách mới");
                }
                //update lại mã đoàn
                int madoanNEW = busDoan.getMD_hientai();
                if (busKhachHang.suaMD(madoanNEW, makh))
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng xong !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thất bại !");

                }






            }
            
                
            
            this.Hide();
           



        }

        private void comboQuocTich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {

        }
    }
}
