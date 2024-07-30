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
    public class BUS_APDUNGCHINHSACH
    {
        DAL_APDUNGCHINHSACH dalAPDUNGCS = new DAL_APDUNGCHINHSACH();

        public DataTable getAPDUNGCS()
        {
            return dalAPDUNGCS.getAPDUNGCHINHSACH();
        }

        public bool themAPDUNGCS(DTO_APDUNGCHINHSACH tv)
        {
            return dalAPDUNGCS.themAPDUNGCHINHSACH(tv);
        }

        public bool suaAPDUNGCS(DTO_APDUNGCHINHSACH tv)
        {
            return dalAPDUNGCS.suaAPDUNGCHINHSACH(tv);
        }

        public bool xoaAPDUNGCS(int MACS)
        {
            return dalAPDUNGCS.xoaAPDUNGCHINHSACH(MACS);
        }
    }
}
