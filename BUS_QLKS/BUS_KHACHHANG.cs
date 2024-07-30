using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLKS;
using DTO_QLKS;
using System.Data;

namespace BUS_QLKS
{
    public class BUS_KHACHHANG
    {
        DAL_KHACHHANG dalkh =new DAL_KHACHHANG();
        public string layHoTenKH(int MaNguoiDat)
        {
            return dalkh.layHoTenKH(MaNguoiDat);
        }
        public int getKH_hientai()
        {
            return dalkh.getMaKH_MoiNhat();
        }
        public DataTable getKH()
        {
            return dalkh.getKHACHHANG();
        }
        public bool themKH(DTO_KHACHHANG kh)
        {
            return dalkh.themKHACHHANG(kh);
        }

        public DataTable dsKhachNhanPhong(string madp)
        {
            return dalkh.dsKhachNhanPhong(madp);
        }
        public DataTable layDuLieuKH(string CCCD)
        {
            return dalkh.docThongTin(CCCD);
        }
        public DataTable getMAKH(string CCCD)
        {
            return dalkh.getMAKH(CCCD);
        }
        //public DataTable themKhachNhanPhong(string madp,string mapnp,string CCCD_PASSPORT, string TENKH, string SDT, string EMAIL, string DIACHI, string QUOCTICH)
        //{
        //    //return dalKHACHHANG.themKhachNhanPhong_checkin(madp,mapnp, CCCD_PASSPORT, TENKH,SDT,EMAIL,DIACHI,QUOCTICH);
        //}
        public DataTable khachNhanPhong()
        {
            return dalkh.getkhachNhanPhong();
        }

        public bool suaMD(int MD, int MAKH)
        {
            return dalkh.suaKH_Madoan(MD, MAKH);    
        }    



    }
}
