using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_NHANVIEN
    {
        private int _MANV;
        private string _TENNV;
        private string _SDT;
        private string _EMAIL;
        private string _DIACHI;


        /* ======== GETTER/SETTER ======== */
        public int MANV
        {
            get
            {
                return _MANV;
            }

            set
            {
                _MANV = value;
            }
        }
        public string TENNV
        {
            get
            {
                return _TENNV;
            }

            set
            {
                _TENNV = value;
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
                _SDT =  value;
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
        public DTO_NHANVIEN()
        {

        }

        public DTO_NHANVIEN(int manv, string tennv, string sdt, string email, string diachi)
        {
            this._MANV = manv;
            this._TENNV = tennv;
            this._SDT = sdt;
            this._EMAIL = email;
            this._DIACHI = diachi;
        }
    }
}
