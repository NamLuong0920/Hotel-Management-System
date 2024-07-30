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
    public class BUS_PHIEUDANGKI_DVTC
    {
        DAL_PHIEUDANGKY_DVTC dalPDK_DVTC = new DAL_PHIEUDANGKY_DVTC();

        public DataTable getPDK_DVTC()
        {
            return dalPDK_DVTC.getPHIEUDANGKY_DVTC();
        }

        public bool themPDK_DVTC(string madvtc, string mapnp, DateTime ngayDK, DateTime ngaySD)
        {
            DTO_PHIEUDANGKY_DVTC dktc = new DTO_PHIEUDANGKY_DVTC(int.Parse(madvtc), int.Parse(mapnp), ngayDK, ngaySD);
            return dalPDK_DVTC.themPHIEUDANGKY_DVTC(dktc);
        }

        public bool suaPDK_DVTC(DTO_PHIEUDANGKY_DVTC tv)
        {
            return dalPDK_DVTC.suaPHIEUDANGKY_DVTC(tv);
        }

    }
}
