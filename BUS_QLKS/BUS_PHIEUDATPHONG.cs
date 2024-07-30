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
    public class BUS_PHIEUDATPHONG
    {
        DAL_PHIEUDATPHONG dalpdp = new DAL_PHIEUDATPHONG();
        public DataTable getPDP()
        {
            return dalpdp.getPHIEUDATPHONG();
        }

        public bool themPDP(DTO_PHIEUDATPHONG pdp)
        {
            return dalpdp.themPHIEUDATPHONG(pdp);
        }
        public int getMADP_hientai()
        {
            return dalpdp.getMaPDP_MoiNhat();
        }

        public int layNGUOIDAT(int mp)
        {
            return dalpdp.layNGUOIDAT(mp);
        }
        /*public bool suaThanhVien(DTO_PHIEUNHANPHONG tv)
        {
            return dalPNP.suaPHIEUNHANPHONG(tv);
        }

        public bool xoaPNP(int MAPNP)
        {
            return dalPNP.xoaPHIEUNHANPHONG(MAPNP);
        }*/
        public DataTable getPDP_HienTai()
        {
            return dalpdp.getPHIEUDATPHONG_HienTai();
        }
        public DataTable getPDP_canGiaHan(string maDP)
        {
            return dalpdp.getPHIEUDATPHONG_canGiaHan(maDP);
        }
        public bool capNhatTinhTrangDuyet(string maGH)
        {
            DAL_GIAHAN dalGIAHAN = new DAL_GIAHAN();
            DataTable giahan = dalGIAHAN.getGIAHAN_STT(maGH);
            string madp = giahan.Rows[0][1].ToString();
            string songaygiahan = giahan.Rows[0][2].ToString();

            return dalpdp.CapNhatPDP_GiaHan(madp, songaygiahan);
           
        }
    }
}
