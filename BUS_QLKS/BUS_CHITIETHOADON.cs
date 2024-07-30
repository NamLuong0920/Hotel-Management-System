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
    public class BUS_CHITIETHOADON
    {
        DAL_CHITIETHOADON dalCTHD = new DAL_CHITIETHOADON();

        public DataTable getCHITIETHOADON()
        {
            return dalCTHD.getCHITIETHOADON();
        }

        public bool themCTHD(DTO_CHITIETHOADON cthdon)
        {
            return dalCTHD.themCHITIETHOADON(cthdon);
        }

        public bool suaCTHD(DTO_CHITIETHOADON cthdon)
        {
            return dalCTHD.suaCHITIETHOADON(cthdon);
        }

        public bool xoaCHITIETHOADON(int MAHOADON)
        {
            return dalCTHD.xoaCHITIETHOADON(MAHOADON);
        }
    }
}
