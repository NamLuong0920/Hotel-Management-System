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
    public class BUS_PHONG_CSVC
    {
        DAL_PHONG_CSVC dal_PHONG_CSVC = new DAL_PHONG_CSVC();

        public DataTable getPHONG_CSVC()
        {
            return dal_PHONG_CSVC.getPHONG_CSVC();
        }

        public bool themPHONG_CSVC(DTO_PHONG_CSVC tv)
        {
            return dal_PHONG_CSVC.themPHONG_CSVC(tv);
        }

        public bool suaPHONG_CSVC(DTO_PHONG_CSVC tv)
        {
            return dal_PHONG_CSVC.suaPHONG_CSVC(tv);
        }

        public bool xoaPHONG_CSVC(int MAPHONG, int MACSVC)
        {
            return dal_PHONG_CSVC.xoaPHONG_CSVC(MAPHONG, MACSVC);
        }
    }
}
