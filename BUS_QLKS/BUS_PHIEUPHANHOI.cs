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
    public class BUS_PHIEUPHANHOI
    {
        DAL_PHIEUPHANHOI dalPHIEUPH = new DAL_PHIEUPHANHOI();

        public DataTable getPHIEUPHANHOI()
        {
            return dalPHIEUPH.getPHIEUPHANHOI();
        }

        public bool themPHIEUPHANHOI(DTO_PHIEUPHANHOI phphanhoi)
        {
            return dalPHIEUPH.themPHIEUPHANHOI(phphanhoi);
        }

        public bool suaPHIEUPH(DTO_PHIEUPHANHOI phphanhoi)
        {
            return dalPHIEUPH.suaPHIEUPHANHOI(phphanhoi);
        }

        public bool xoaPHIEUPHANHOI(int MAPH)
        {
            return dalPHIEUPH.xoaPHIEUPHANHOI(MAPH);
        }
    }
}
