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
    public class BUS_DOITACDICHVU
    {
        DAL_DOITACDICHVU dalDOITACDV = new DAL_DOITACDICHVU();

        public DataTable getDOITACDV()
        {
            return dalDOITACDV.getDOITACDICHVU();
        }

        public bool themDOITACDV(DTO_DOITACDICHVU tv)
        {
            return dalDOITACDV.themDOITACDICHVU(tv);
        }

        public bool suaDOITACDV(DTO_DOITACDICHVU tv)
        {
            return dalDOITACDV.suaDOITACDICHVU(tv);
        }

        public bool xoaDOITACDV(int MADOITACDV)
        {
            return dalDOITACDV.xoaDOITACDICHVU(MADOITACDV);
        }
    }
}
