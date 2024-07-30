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
    public class BUS_NHANVIEN
    {
        DAL_NHANVIEN dalNV = new DAL_NHANVIEN();

        public DataTable getNV()
        {
            return dalNV.getNHANVIEN();
        }

        public bool themNV(DTO_NHANVIEN tv)
        {
            return dalNV.themNHANVIEN(tv);
        }

        public bool suaNV(DTO_NHANVIEN tv)
        {
            return dalNV.suaNHANVIEN(tv);
        }

        public bool xoaNV(int MANV)
        {
            return dalNV.xoaNHANVIEN(MANV);
        }
    }
}
