using BUS_QLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QLKS
{
    public partial class GUI_CHECKIN_YEUCAUDACBIET : Form
    {
        BUS_PHIEUDATPHONG busPDP = new BUS_PHIEUDATPHONG();
        public static string madp;
        public GUI_CHECKIN_YEUCAUDACBIET()
        {
            InitializeComponent();
        }
        public GUI_CHECKIN_YEUCAUDACBIET(string MADP)
        {
            InitializeComponent();
            madp=MADP;
            txtYEUCAUDACBIET.Enabled = false;
            txtYEUCAUDACBIET.Text = busPDP.layThongTinYeuCauDacBiet(MADP).Rows[0]["YEUCAUDACBIET"].ToString();
        }
        
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            txtYEUCAUDACBIET.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtYEUCAUDACBIET.Text))
                {
                    busPDP.suaYeuCauDacBiet(madp, txtYEUCAUDACBIET.Text);
                }
                else
                {
                    busPDP.suaYeuCauDacBiet(madp, "không có");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể cập nhật", "Thông báo");
            }
            finally
            {
                MessageBox.Show("Đã cập nhật thành công!");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_CHECKIN CHECKINFORM = new GUI_CHECKIN();
            CHECKINFORM.Show();
        }

        private void txtYEUCAUDACBIET_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
