using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLKS;
using DTO_QLKS;
using System.Data;
using System.Xml.Linq;

namespace BUS_QLKS
{
    public class BUS_GIAHAN
    {
        DAL_GIAHAN dalGIAHAN = new DAL_GIAHAN();

        public DataTable getGIAHAN()
        {
            return dalGIAHAN.getGIAHAN();
        }

        public bool themGIAHAN(string maDP,int ttgh)
        {
            // Tạo DTo
            DTO_GIAHAN gh = new DTO_GIAHAN(0, int.Parse(maDP), ttgh, "N'CHƯA DUYỆT'");
            return dalGIAHAN.themGIAHAN(gh);
        }

        public bool suaGIAHAN(DTO_GIAHAN ghan)
        {
            return dalGIAHAN.suaGIAHAN(ghan);
        }

        public bool xoaGIAHAN(int STT)
        {
            return dalGIAHAN.xoaGIAHAN(STT);
        }
        public DataTable getGIAHAN(string MADP)
        {
            return dalGIAHAN.getGIAHAN(MADP);
        }
        public bool capNhatTinhTrangDuyet(string maGH,string tinhtrangduyet)
        {
            DataTable giahan = dalGIAHAN.getGIAHAN_STT(maGH) ;
            string madp = giahan.Rows[0][1].ToString();
            string songaygiahan = giahan.Rows[0][2].ToString();

            DTO_GIAHAN GIAHAN = new DTO_GIAHAN(int.Parse(maGH), int.Parse(madp), int.Parse(songaygiahan), tinhtrangduyet);
            return dalGIAHAN.capNhatTinhTrangDuyet(GIAHAN);
        }
    }
}
