using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHIEUTRAPHONG
    {
        private int _MATP;
        private DateTime _NGAYCHECKOUT;
        private int _MAPH;
        private int _MADP;

        /* ======== GETTER/SETTER ======== */
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
        public DateTime NGAYCHECKOUT
        {
            get
            {
                return _NGAYCHECKOUT;
            }

            set
            {
                _NGAYCHECKOUT = value;
            }
        }
        public int MAPH
        {
            get
            {
                return _MAPH;
            }

            set
            {
                _MAPH = value;
            }
        }
        public int MADP
        {
            get
            {
                return _MADP;
            }

            set
            {
                _MADP = value;
            }
        }
        /* === Constructor === */
        public DTO_PHIEUTRAPHONG()
        {

        }

        public DTO_PHIEUTRAPHONG(int matp, DateTime ngaycheckout, int maph, int madp)
        {
            this._MATP = matp;
            this._NGAYCHECKOUT = ngaycheckout;
            this._MAPH = maph;
            this._MADP = madp;
        }
    }
}
