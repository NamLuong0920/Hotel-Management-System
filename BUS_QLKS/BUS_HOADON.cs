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
    public class BUS_HOADON
    {
        DAL_HOADON dalHOADON = new DAL_HOADON();

        public DataTable getHOADON()
        {
            return dalHOADON.getHOADON();
        }

        public DateTime getCurrentDate()
        {
            return dalHOADON.getCurrentDate();
        }
        public decimal tinhTienPhong(int MaNguoiDat)
        {
            return dalHOADON.tinhTienPhong(MaNguoiDat);
        }
        public decimal tinhTienCSVC(int MaNguoiDat)
        {
            return dalHOADON.tinhTienCSVC(MaNguoiDat);
        }
        public decimal tinhTienDV(int MaNguoiDat)
        {
            return dalHOADON.tinhTienDV(MaNguoiDat);
        }
        public decimal tinhTienCoc(int MaNguoiDat)
        {
            return dalHOADON.tinhTienCoc(MaNguoiDat);
        }
        public bool themHOADON(DTO_HOADON hdon)
        {
            return dalHOADON.themHOADON(hdon);
        }

        public bool suaHOADON(DTO_HOADON hdon)
        {
            return dalHOADON.suaHOADON(hdon);
        }

        public bool xoaHOADON(int MAHOADON)
        {
            return dalHOADON.xoaHOADON(MAHOADON);
        }
    }
}
