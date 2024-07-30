using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DAILYTRUNGGIAN
    {
        private int _MADAILY;
        private string _TENDAILY;
        private string _SDT;
        private string _EMAIL;
        private string _DIACHI;

        /* ======== GETTER/SETTER ======== */
        public int MADAILY
        {
            get
            {
                return _MADAILY;
            }

            set
            {
                _MADAILY = value;
            }
        }
        public string TENDAILY
        {
            get
            {
                return _TENDAILY;
            }

            set
            {
                _TENDAILY = value;
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

        /* === Constructor === */
        public DTO_DAILYTRUNGGIAN()
        {

        }

        public DTO_DAILYTRUNGGIAN(int madl, string tendl, string sdt, string email, string diachi)
        {
            this._MADAILY = madl;
            this._TENDAILY = tendl;
            this._SDT = sdt;
            this._EMAIL = email;
            this._DIACHI = diachi;
        }
    }
}
