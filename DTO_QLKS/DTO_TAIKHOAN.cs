using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_TAIKHOAN
    {
        private string _USERNAME;
        private string _U_PASSWORD;
        private int _MANV;
        private string _VAITRO;

        /* ======== GETTER/SETTER ======== */
        public string USERNAME
        {
            get
            {
                return _USERNAME;
            }

            set
            {
                _USERNAME = value;
            }
        }
        public string U_PASSWORD
        {
            get
            {
                return _U_PASSWORD;
            }

            set
            {
                _U_PASSWORD = value;
            }
        }
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
        public string VAITRO
        {
            get
            {
                return _VAITRO;
            }

            set
            {
                _VAITRO = value;
            }
        }
        /* === Constructor === */
        public DTO_TAIKHOAN()
        {

        }

        public DTO_TAIKHOAN(string username, string u_password, int manv, string vaitro)
        {
            this._USERNAME = username;
            this._U_PASSWORD = u_password;
            this._MANV = manv;
            this._VAITRO = vaitro;
        }
    }
}
