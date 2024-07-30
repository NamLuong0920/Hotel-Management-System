using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_COSOVATCHAT
    {
        private int _MAVATCHAT;
        private string _TENVATCHAT;
        private decimal _GIA;

        /* ======== GETTER/SETTER ======== */
        public int MAVATCHAT
        {
            get
            {
                return _MAVATCHAT;
            }

            set
            {
                _MAVATCHAT = value;
            }
        }
        public string TENVATCHAT
        {
            get
            {
                return _TENVATCHAT;
            }

            set
            {
                _TENVATCHAT = value;
            }
        }
        public decimal GIA
        {
            get
            {
                return _GIA;
            }

            set
            {
                _GIA = value;
            }
        }

        /* === Constructor === */
        public DTO_COSOVATCHAT()
        {

        }

        public DTO_COSOVATCHAT(int mavc, string tenvc, decimal gia)
        {
            this._MAVATCHAT = mavc;
            this._TENVATCHAT = tenvc;
            this._GIA = gia;
        }
    }
}
