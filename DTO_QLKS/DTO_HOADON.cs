using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_HOADON
    {
        private int _MAHOADON;
        private int _MATP;
        private DateTime _THOIDIEMTHANHTOAN;
        private string _HINHTHUCTHANHTOAN;
        private decimal _TIENCOC;
        private decimal _TONGTIEN;
        private int _NGUOILAPHOADON;

        /* ======== GETTER/SETTER ======== */
        public int MAHOADON
        {
            get
            {
                return _MAHOADON;
            }

            set
            {
                _MAHOADON = value;
            }
        }
        public int MATP
        {
            get
            {
                return _MATP;
            }

            set
            {
                _MATP = value;
            }
        }
        public DateTime THOIDIEMTHANHTOAN
        {
            get
            {
                return _THOIDIEMTHANHTOAN;
            }

            set
            {
                _THOIDIEMTHANHTOAN = value;
            }
        }
        public string HINHTHUCTHANHTOAN
        {
            get
            {
                return _HINHTHUCTHANHTOAN;
            }

            set
            {
                _HINHTHUCTHANHTOAN = value;
            }
        }
        public decimal TIENCOC
        {
            get
            {
                return _TIENCOC;
            }

            set
            {
                _TIENCOC = value;
            }
        }
        public decimal TONGTIEN
        {
            get
            {
                return _TONGTIEN;
            }

            set
            {
                _TONGTIEN = value;
            }
        }
        public int NGUOILAPHOADON
        {
            get
            {
                return _NGUOILAPHOADON;
            }

            set
            {
                _NGUOILAPHOADON = value;
            }
        }
        /* === Constructor === */
        public DTO_HOADON()
        {

        }

        public DTO_HOADON(int mahdon, int matp, DateTime tdthanhtoan, string htthanhtoan, decimal tiencoc, decimal tongtien, int nglaphoadon)
        {
            this._MAHOADON = mahdon;
            this._MATP = matp;
            this._THOIDIEMTHANHTOAN = tdthanhtoan;
            this._HINHTHUCTHANHTOAN = htthanhtoan;
            this._TIENCOC = tiencoc;
            this._TONGTIEN = tongtien;
            this._NGUOILAPHOADON = nglaphoadon;
        }
    }
}
