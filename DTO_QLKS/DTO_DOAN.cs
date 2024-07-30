using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DOAN
    {
        private int _MADOAN;
        private string _TENDOAN;
        private int _TRUONGDOAN;
        private int _SONGUOI;


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
        public string TENDOAN
        {
            get
            {
                return _TENDOAN;
            }

            set
            {
                _TENDOAN = value;
            }
        }
        public int TRUONGDOAN
        {
            get
            {
                return _TRUONGDOAN;
            }

            set
            {
                _TRUONGDOAN = value;
            }
        }
        public int SONGUOI
        {
            get
            {
                return _SONGUOI;
            }

            set
            {
                _SONGUOI = value;
            }
        }

        /* === Constructor === */
        public DTO_DOAN()
        {

        }

        public DTO_DOAN(int madoan, string tendoan, int truongdoan,int songuoi)
        {
            this._MADOAN = madoan;
            this._TENDOAN = tendoan;
            this._TRUONGDOAN = truongdoan;
            this._SONGUOI = songuoi;
        }
    }
}
