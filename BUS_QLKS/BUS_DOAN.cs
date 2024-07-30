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
    public class BUS_DOAN
    {
        DAL_DOAN dalDoan = new DAL_DOAN();
        /* public int getMaDOAN_hientai()
         {
             return dalkh.getMaKH_MoiNhat();
         }*/
        public DataTable getDOAN()
        {
            return dalDoan.getDOAN();
        }
        public bool themDOAN(DTO_DOAN d)
        {
            return dalDoan.themDOAN(d);
        }
        public int getMD_hientai()
        {
            return dalDoan.getMD_MoiNhat();

        }
    }
}
