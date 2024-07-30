using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHONG_CSVC
    {
        private int _MAPHONG;
        private int _MA_CSVC;
        private int _SOLUONG;

        /* ======== GETTER/SETTER ======== */
        public int MAPHONG
        {
            get
            {
                return _MAPHONG;
            }

            set
            {
                _MAPHONG = value;
            }
        }
        public int MA_CSVC
        {
            get
            {
                return _MA_CSVC;
            }

            set
            {
                _MA_CSVC = value;
            }
        }
        public int SOLUONG
        {
            get
            {
                return _SOLUONG;
            }

            set
            {
                _SOLUONG = value;
            }
        }

        /* === Constructor === */
        public DTO_PHONG_CSVC()
        {

        }

        public DTO_PHONG_CSVC(int maphg,int macsvc, int soluong)
        {
            this._MAPHONG = maphg;
            this._MA_CSVC = macsvc;
            this._SOLUONG = soluong;

    }
    }
}
