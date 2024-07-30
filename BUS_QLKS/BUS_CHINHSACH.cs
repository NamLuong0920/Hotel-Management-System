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
    public class BUS_CHINHSACH
    {
        DAL_CHINHSACH dalCHINHSACH = new DAL_CHINHSACH();

        public DataTable getThanhVien()
        {
            return dalCHINHSACH.getCHINHSACH();
        }

        public bool themCHINHSACH(DTO_CHINHSACH tv)
        {
            return dalCHINHSACH.themCHINHSACH(tv);
        }

        public bool suaCHINHSACH(DTO_CHINHSACH tv)
        {
            return dalCHINHSACH.suaCHINHSACH(tv);
        }

        public bool xoaCHINHSACH(int MACS)
        {
            return dalCHINHSACH.xoaCHINHSACH(MACS);
        }
    }
}
