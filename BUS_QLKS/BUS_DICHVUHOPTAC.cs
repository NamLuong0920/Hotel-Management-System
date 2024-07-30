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
    public class BUS_DICHVUHOPTAC
    {
        DAL_DICHVUHOPTAC dalDVHT = new DAL_DICHVUHOPTAC();

        public DataTable getDVHT()
        {
            return dalDVHT.getDICHVUHOPTAC();
        }

        public bool themDVHT(DTO_DICHVUHOPTAC tv)
        {
            return dalDVHT.themDICHVUHOPTAC(tv);
        }

        public bool suaDVHT(DTO_DICHVUHOPTAC tv)
        {
            return dalDVHT.suaDICHVUHOPTAC(tv);
        }

        public bool xoaDVHT(int MADVHT)
        {
            return dalDVHT.xoaDICHVUHOPTAC(MADVHT);
        }

        public DataTable getPNP()
        {
            return dalDVHT.getPNP();
        }
    }
}
