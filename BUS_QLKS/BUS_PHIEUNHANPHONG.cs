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
    public class BUS_PHIEUNHANPHONG
    {
        DAL_PHIEUNHANPHONG dalPNP = new DAL_PHIEUNHANPHONG();

        public DataTable getPNP()
        {
            return dalPNP.getPhieuNhanPhong();
        }

        public bool themPNP(DTO_PHIEUNHANPHONG tv)
        {
            return dalPNP.themPHIEUNHANPHONG(tv);
        }

        public bool suaThanhVien(DTO_PHIEUNHANPHONG tv)
        {
            return dalPNP.suaPHIEUNHANPHONG(tv);
        }

        public bool xoaPNP(int MAPNP)
        {
            return dalPNP.xoaPHIEUNHANPHONG(MAPNP);
        }
        public bool kiemTraTinhTrangPhong(string maphong, string tuNgay, string denNgay)
        {
            DataTable dt = new DataTable();
            dt = dalPNP.kiemTraTinhTrangPhong(maphong,tuNgay,denNgay);
            if (dt.Rows.Count == 0) {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
