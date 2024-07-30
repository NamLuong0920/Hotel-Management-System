using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QLKS;
using BUS_QLKS;

namespace QLKS
{
    public partial class GUI_DANGNHAP : Form
    {
        BUS_TAIKHOAN busTK = new BUS_TAIKHOAN();
        public GUI_DANGNHAP()
        {
            InitializeComponent();
        }

        private void GUI_DANGNHAP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string taiKhoan = Txt_username.Text;
            string matKhau = Txt_Password.Text;
            if (taiKhoan == "" || matKhau == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Thông báo");
            }
            else
            {
                bool check = true;
                try
                {
                    check = busTK.kiemTraTAIKHOAN(taiKhoan, matKhau);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", "Thông báo");

                }
                if (check == true)
                {
                    MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG!");
                    string vaitro = busTK.getVaiTro(taiKhoan);
                    MessageBox.Show(vaitro, "Vai trò là ");
                    if (vaitro == "LỄ TÂN")
                    {
                        this.Hide();
                        GUI_TRANGCHULETAN TRANGCHULETANFORM = new GUI_TRANGCHULETAN();
                        TRANGCHULETANFORM.Show();
                    }
                    else if (vaitro == "BELLMAN")
                    {
                        this.Hide();
                        GUI_TRANGCHUBELLMAN TRANGCHUBELLMANFORM = new GUI_TRANGCHUBELLMAN();
                        TRANGCHUBELLMANFORM.Show();
                    }
                    else if (vaitro == "BUỒNG PHÒNG")
                    {
                        this.Hide();
                        GUI_TRANGCHUBUONGPHONG TRANGCHUBUONGPHONGFORM = new GUI_TRANGCHUBUONGPHONG();
                        TRANGCHUBUONGPHONGFORM.Show();
                    }
                }
                else
                {
                    MessageBox.Show("\t\tĐĂNG NHẬP THẤT BẠI! \nVUI LÒNG KIỂM TRA LẠI TÊN ĐĂNG NHẬP VÀ MẬT KHẨU","Thông báo");
                }

            }

        }

        private void btxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
