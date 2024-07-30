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
    public class BUS_COSOVATCHAT
    {
        DAL_COSOVATCHAT dalCSVC = new DAL_COSOVATCHAT();

        public DataTable getCSVC()
        {
            return dalCSVC.getCOSOVATCHAT();
        }

        public bool themCSVC(DTO_COSOVATCHAT tv)
        {
            return dalCSVC.themCOSOVATCHAT(tv);
        }

        public bool suaCSVC(DTO_COSOVATCHAT tv)
        {
            return dalCSVC.suaCOSOVATCHAT(tv);
        }

        public bool xoaCSVC(int MAVATCHAT)
        {
            return dalCSVC.xoaCOSOVATCHAT(MAVATCHAT);
        }
    }
}
