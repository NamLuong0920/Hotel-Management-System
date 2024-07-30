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
    public class BUS_HONGHOC
    {
        DAL_HONGHOC dalHONGHOC = new DAL_HONGHOC();

        public DataTable getHONGHOC()
        {
            return dalHONGHOC.getHONGHOC();
        }

        public bool themHONGHOC(DTO_HONGHOC hhoc)
        {
            return dalHONGHOC.themHONGHOC(hhoc);
        }

        public bool suaHONGHOC(DTO_HONGHOC hhoc)
        {
            return dalHONGHOC.suaHONGHOC(hhoc);
        }

        public bool xoaHONGHOC(int MAHONGHOC)
        {
            return dalHONGHOC.xoaHONGHOC(MAHONGHOC);
        }
    }
}
