using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL_QLKS;
using DTO_QLKS;

namespace BUS_QLKS
{
    public class BUS_TAIKHOAN
    {
        DAL_TAIKHOAN dalTaiKhoan = new DAL_TAIKHOAN();
        public DataTable getTAIKHOAN()
        {
            return dalTaiKhoan.getTAIKHOAN();
        }

        public bool themTAIKHOAN(DTO_TAIKHOAN tk)
        {
            return dalTaiKhoan.themTAIKHOAN(tk);
        }

        public bool suaTAIKHOAN(DTO_TAIKHOAN tk)
        {
            return dalTaiKhoan.suaTAIKHOAN(tk);
        }

        public bool xoaTAIKHOAN(string USERNAME)
        {
            return dalTaiKhoan.xoaTAIKHOAN(USERNAME);
        }
        public bool kiemTraTAIKHOAN(string USERNAME, string PASSWORD)
        {
            bool check = dalTaiKhoan.kiemTraTAIKHOAN(USERNAME, PASSWORD);
            return check;
        }
        public string getVaiTro(string USERNAME)
        {
            string vaitro = dalTaiKhoan.getVaiTro(USERNAME);
            return vaitro;
        }
    }

}

