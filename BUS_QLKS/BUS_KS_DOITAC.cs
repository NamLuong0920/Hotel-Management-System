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
    public class BUS_KS_DOITAC
    {
        DAL_KS_DOITAC dalKS_DOITAC = new DAL_KS_DOITAC();

        public DataTable getKS_DOITAC()
        {
            return dalKS_DOITAC.getKS_DOITAC();
        }

        public bool themKS_DOITAC(DTO_KS_DOITAC tv)
        {
            return dalKS_DOITAC.themKS_DOITAC(tv);
        }

        public bool suaKS_DOITAC(DTO_KS_DOITAC tv)
        {
            return dalKS_DOITAC.suaKS_DOITAC(tv);
        }

        public bool xoaKS_DOITAC(int MAKSDT)
        {
            return dalKS_DOITAC.xoaKS_DOITAC(MAKSDT);
        }
    }
}
