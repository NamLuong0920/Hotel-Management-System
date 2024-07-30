using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHONG
    {
        private int _MAPHONG;
        private int _MALP;
        private string _TINHTRANGTHUE;
        private string _TINHTRANGVESINH;

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
        /* ======== GETTER/SETTER ======== */
        public int MALP
        {
            get
            {
                return _MALP;
            }

            set
            {
                _MALP =  value;
            }
        }
        public string TINHTRANGTHUE
        {
            get
            {
                return _TINHTRANGTHUE;
            }

            set
            {
                _TINHTRANGTHUE = value;
            }
        }
        public string TINHTRANGVESINH
        {
            get
            {
                return _TINHTRANGVESINH;
            }

            set
            {
                _TINHTRANGVESINH = value;
            }
        }

        /* === Constructor === */
        public DTO_PHONG()
        {

        }

        public DTO_PHONG(int maphong, int malp, string tinhtrangthue, string tinhtrangvesinh)
        {
            this._MAPHONG = maphong;
            this._MALP = malp;
            this._TINHTRANGTHUE = tinhtrangthue;
            this._TINHTRANGVESINH = tinhtrangvesinh;
        }
    }
}
