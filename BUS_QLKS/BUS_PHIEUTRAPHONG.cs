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
    public class BUS_PHIEUTRAPHONG
    {
        DAL_PHIEUTRAPHONG dalPTP = new DAL_PHIEUTRAPHONG();

        public DataTable getPHIEUTRAPHONG()
        {
            return dalPTP.getPHIEUTRAPHONG();
        }

        public bool themPHIEUTRAPHONG(DTO_PHIEUTRAPHONG phtraphong)
        {
            return dalPTP.themPHIEUTRAPHONG(phtraphong);
        }

        public bool suaPHIEUTRAPHONG(DTO_PHIEUTRAPHONG phtraphong)
        {
            return dalPTP.suaPHIEUTRAPHONG(phtraphong);

        }

        public bool xoaPHIEUTRAPHONG(int MATP)
        {
            return dalPTP.xoaPHIEUTRAPHONG(MATP);
        }
    }
}
