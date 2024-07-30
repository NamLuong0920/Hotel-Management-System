using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_KS_DOITAC
    {
        private int _MAKSDT;
        private string _TENKS;
        private string _MOTA;
        private string _DIACHI;
        private string _EMAIL;
        private string _SDT;

        /* ======== GETTER/SETTER ======== */
        public int MAKSDT
        {
            get
            {
                return _MAKSDT;
            }

            set
            {
                _MAKSDT = value;
            }
        }
        public string TENKS
        {
            get
            {
                return _TENKS;
            }

            set
            {
                _TENKS = value;
            }
        }
        public string MOTA
        {
            get
            {
                return _MOTA;
            }

            set
            {
                _MOTA = value;
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
        /* === Constructor === */
        public DTO_KS_DOITAC()
        {

        }

        public DTO_KS_DOITAC(int maksdt, string tenks, string mota, string diachi, string email, string sdt)
        {
            this._MAKSDT = maksdt;
            this._TENKS = tenks;
            this._MOTA = mota;
            this._DIACHI = diachi;
            this._EMAIL = email;
            this._SDT = sdt;
        }
    }
}
