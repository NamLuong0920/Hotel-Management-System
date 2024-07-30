using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHIEUDANGKY_DVHT
    {
        private int _MADVHT;
        private int _MADP;
        private int _SONGUOI;
        private DateTime _THOIGIANKHOIHANH;
        private string _DICHUYEN;
        private string _TINHTRANGDUYET;
        private DateTime _THOIGIANKETTHUC;


        //
        public int MADVHT
        {
            get
            {
                return _MADVHT;
            }
            set
            {
                _MADVHT = value;
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
        public DateTime THOIGIANKHOIHANH
        {
            get
            {
                return _THOIGIANKHOIHANH;
            }
            set
            {
                _THOIGIANKHOIHANH = value;
            }
        }
        public string DICHUYEN
        {
            get
            {
                return _DICHUYEN;
            }
            set
            {
                _DICHUYEN = value;
            }
        }
        public string TINHTRANGDUYET
        {
            get
            {
                return _TINHTRANGDUYET;
            }
            set
            {
                _TINHTRANGDUYET = value;
            }
        }
        public DateTime THOIGIANKETTHUC
        {
            get
            {
                return _THOIGIANKETTHUC;
            }
            set
            {
                _THOIGIANKETTHUC = value;
            }
        }

        public DTO_PHIEUDANGKY_DVHT()
        {

        }

        public DTO_PHIEUDANGKY_DVHT(int MADP, int MADVHT, int SONGUOI, DateTime THOIGIANKHOIHANH, string CACHTHUCDICHUYEN, string TINHTRANGDUYET, DateTime THOIGIANKETTHUC)
        {
            this.MADVHT = MADVHT;
            this.MADP = MADP;
            this.SONGUOI = SONGUOI;
            this.DICHUYEN = CACHTHUCDICHUYEN;
            this.THOIGIANKHOIHANH = THOIGIANKHOIHANH;
            this.THOIGIANKETTHUC = THOIGIANKETTHUC;
            this.TINHTRANGDUYET = TINHTRANGDUYET;
        }

    }
}
