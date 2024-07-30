using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_LOAIPHONG
    {
        private int _MALP;
        private string _TENLP;
        private string _HANGPHONG;
        private decimal _DONGIA;
        private string _MOTA;

        public int MALP
        {
            get
            {
                return _MALP;
            }

            set
            {
                _MALP = value;
            }
        }
        public string TENLP
        {
            get
            {
                return _TENLP;
            }

            set
            {
                _TENLP = value;
            }
        }
        public string HANGPHONG
        {
            get
            {
                return _HANGPHONG;
            }

            set
            {
                _HANGPHONG = value;
            }
        }
        public decimal DONGIA
        {
            get
            {
                return _DONGIA;
            }

            set
            {
                _DONGIA = value;
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

        /* === Constructor === */
        public DTO_LOAIPHONG()
        {

        }

        public DTO_LOAIPHONG(int malp, string tenlp, string hangphong, decimal dongia, string mota)
        {
            this._MALP = malp;
            this._TENLP = tenlp;
            this._HANGPHONG = hangphong;
            this._DONGIA = dongia;
            this._MOTA = mota;

    }

    }
}
