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
    public class BUS_DVTC_LP_HOTRO
    {
        DAL_DV_LP_HOTRO dal_DV_LP_HOTRO = new DAL_DV_LP_HOTRO();

        public DataTable getDV_LP_HOTRO()
        {
            return dal_DV_LP_HOTRO.getDV_LP_HOTRO();
        }

        public bool themDV_LP_HOTRO(DTO_DV_LP_HOTRO tv)
        {
            return dal_DV_LP_HOTRO.themDV_LP_HOTRO(tv);
        }

        public bool suaDV_LP_HOTRO(DTO_DV_LP_HOTRO tv)
        {
            return dal_DV_LP_HOTRO.suaDV_LP_HOTRO(tv);
        }

        public bool xoaDV_LP_HOTRO(int MALP, int MADVTC)
        {
            return dal_DV_LP_HOTRO.xoaDV_LP_HOTRO(MALP, MADVTC);
        }
    }
}
