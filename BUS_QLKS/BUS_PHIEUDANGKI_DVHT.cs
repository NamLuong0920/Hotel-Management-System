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
    public class BUS_PHIEUDANGKI_DVHT
    {
        DAL_PHIEUDANGKI_DVHT dalPDK_DVHT = new DAL_PHIEUDANGKI_DVHT();

        public DataTable getPDK_DVHT()
        {
            return dalPDK_DVHT.getPHIEUDANGKI_DVHT();
        }

        public bool themPDK_DVHT(string MaPDP, string MADVHT, string SoNguoi, DateTime ThoiGianKhoiHanh, string CachThucDiChuyen,
                   string TinhTrangDuyet, DateTime ThoiGianKetThuc)
        {
            DTO_PHIEUDANGKY_DVHT dvht = new DTO_PHIEUDANGKY_DVHT(int.Parse(MaPDP), int.Parse(MADVHT), int.Parse(SoNguoi), ThoiGianKhoiHanh, CachThucDiChuyen,
                      TinhTrangDuyet, ThoiGianKetThuc);
            return dalPDK_DVHT.themPHIEUDANGKI_DVHT(dvht);
        }

        public bool suaThanhVien(DTO_PHIEUDANGKY_DVHT tv)
        {
            return dalPDK_DVHT.suaPHIEUDANGKI_DVHT(tv);
        }

        public bool xoaPDK_DVHT(int MADVHT)
        {
            return dalPDK_DVHT.xoaPHIEUDANGKI_DVHT(MADVHT);
        }
    }
}
