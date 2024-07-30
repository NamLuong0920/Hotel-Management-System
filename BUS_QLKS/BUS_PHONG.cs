using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLKS;
using DTO_QLKS;
using System.Data;
using System.Xml.Linq;

namespace BUS_QLKS
{
    public class BUS_PHONG
    {
        DAL_PHONG dalPHONG = new DAL_PHONG();

        public DataTable getPHONG()
        {
            return dalPHONG.getPhong();
        }
        public DataTable checkPhong(string tinhtrangthue, string tinhtrangvesinh, int lp)
        {

            return dalPHONG.checkPhong(tinhtrangthue, tinhtrangvesinh,lp);
        }

        public bool themPHONG(DTO_PHONG tv)
        {
            return dalPHONG.themPHONG(tv);
        }

        public bool suaPHONG(DTO_PHONG tv)
        {
            return dalPHONG.suaPHONG(tv);
        }

        public bool xoaPHONG(int MAPHONG)
        {
            return dalPHONG.xoaPHONG(MAPHONG);
        }
        public DataTable getPhong_BuongPhong()
        {
            return dalPHONG.getPhong_BuongPhong();
        }
        public DataTable getPhong_BuongPhongTimKiem(string maphong)
        {
            return dalPHONG.getPhong_BuongPhongTimKiem(maphong);
        }
        public bool capNhatVeSinhPHONG(string soPhong, string tinhTrangVeSinhHienTai)
        {
            DataTable phong = dalPHONG.getPhong(soPhong);
            string malp = phong.Rows[0][1].ToString();
            string tinhtrangthue = phong.Rows[0][2].ToString();

            DTO_PHONG phg = new DTO_PHONG(int.Parse(soPhong), int.Parse(malp), tinhtrangthue, tinhTrangVeSinhHienTai); // Vì ID tự tăng nên để ID số gì cũng dc

            return dalPHONG.suaPHONG(phg);
        }

        public DataTable getDSPhong_MaNguoiDat(int MaNguoiDat)
        {
            return dalPHONG.getDSPhong_MaNguoiDat(MaNguoiDat);
        }

        public DataTable getHongHoc_DSPhong_MaNguoiDat(int MaNguoiDat)
        {
            return dalPHONG.getHongHoc_DSPhong_MaNguoiDat(MaNguoiDat);
        }

        public DataTable getDichVu_DSPhong_MaNguoiDat(int MaNguoiDat)
        {
            return dalPHONG.getDichVu_DSPhong_MaNguoiDat(MaNguoiDat);
        }
    }
}
