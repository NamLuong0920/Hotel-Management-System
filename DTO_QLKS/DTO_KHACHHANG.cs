using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_KHACHHANG
    {
        private int _MADOAN;
        private int _MAKH;
        private string _CCCD_PASSPORT;
        private string _TENKH;
        private string _SDT;
        private string _EMAIL;
        private string _DIACHI;
        private string _QUOCTICH;

        /* ======== GETTER/SETTER ======== */
        public int MADOAN
        {
            get
            {
                return _MADOAN;
            }

            set
            {
                _MADOAN = value;
            }
        }
        public int MAKH
        {
            get
            {
                return _MAKH;
            }

            set
            {
                _MAKH = value;
            }
        }
        public string CCCD_PASSPORT
        {
            get
            {
                return _CCCD_PASSPORT;
            }

            set
            {
                _CCCD_PASSPORT = value;
            }
        }
        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                _SDT = value;
            }
        }
        public string TENKH
        {
            get
            {
                return _TENKH;
            }

            set
            {
                _TENKH = value;
            }
        }
        public string EMAIL
        {
            get
            {
                return _EMAIL;
            }

            set
            {
                _EMAIL = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return _DIACHI;
            }

            set
            {
                _DIACHI = value;
            }
        }
        public string QUOCTICH
        {
            get
            {
                return _QUOCTICH;
            }

            set
            {
                _QUOCTICH = value;
            }
        }

        /* === Constructor === */
        public DTO_KHACHHANG()
        {
            return;
        }

        public DTO_KHACHHANG(int madoan,int makh,string cccdpassport, string tenkh, string sdt, string email, string diachi, string quoctich)
        {
            this._MADOAN = madoan;
            this._MAKH = makh;
            this._CCCD_PASSPORT = cccdpassport;
            this._TENKH = tenkh;
            this._SDT = sdt;
            this._EMAIL = email;
            this._DIACHI = diachi;
            this._QUOCTICH = quoctich;
        }
    }
}
