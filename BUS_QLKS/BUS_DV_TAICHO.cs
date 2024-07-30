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
    public class BUS_DV_TAICHO
    {
        DAL_DV_TAICHO dalDVTC = new DAL_DV_TAICHO();

        public DataTable getDVTC()
        {
            return dalDVTC.getDV_TAICHO();
        }

        public bool themDVTC(DTO_DV_TAICHO tv)
        {
            return dalDVTC.themDV_TAICHO(tv);
        }

        public bool suaDVTC(DTO_DV_TAICHO tv)
        {
            return dalDVTC.suaDV_TAICHO(tv);
        }

        public bool xoaDVTC(int MADVTC)
        {
            return dalDVTC.xoaDV_TAICHO(MADVTC);
        }

        public DataTable timKiem_DVTC(string MAPHONG)
        {
            return dalDVTC.timKiemDV_TAICHO(MAPHONG);
        }
    }
}
