using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHIEUDATPHONG
    {
        private int _MADP;
        private int _MADAILY;
        private int _NGUOIDAT;
        private string _NGAYDEN;
        private string _NGAYDI;
        private string _YEUCAUDACBIET;
        private string _HINHTHUCDATPHONG;
        private string _NGAYDAT;
        private decimal _TIENCOC;
        private decimal _CHIPHIUOCTINH;
        private int _SONGUOI;
        private int _SOPHONG;
        private string _GIAHAN;

        //
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
        public int NGUOIDAT
        {
            get
            {
                return _NGUOIDAT;
            }
            set
            {
                _NGUOIDAT = value;
            }
        }
        public string NGAYDEN
        {
            get
            {
                return _NGAYDEN;
            }
            set
            {
                _NGAYDEN = value;
            }
        }
        public string NGAYDI
        {
            get
            {
                return _NGAYDI;
            }
            set
            {
                _NGAYDI = value;
            }
        }
      
        public string YEUCAUDACBIET
        {
            get
            {
                return _YEUCAUDACBIET;
            }
            set
            {
                _YEUCAUDACBIET = value;
            }
        }
        public string HINHTHUCDATPHONG
        {
            get
            {
                return _HINHTHUCDATPHONG;
            }
            set
            {
                _HINHTHUCDATPHONG = value;
            }
        }
        public string NGAYDAT
        {
            get
            {
                return _NGAYDAT;
            }
            set
            {
                _NGAYDAT = value;
            }
        }
        public Decimal TIENCOC
        {
            get
            {
                return _TIENCOC;
            }
            set
            {
                _TIENCOC = value;
            }
        }
        public Decimal CHIPHIUOCTINH
        {
            get
            {
                return _CHIPHIUOCTINH;
            }
            set
            {
                _CHIPHIUOCTINH = value;
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
        public int SOPHONG
        {
            get
            {
                return _SOPHONG;
            }
            set
            {
                _SOPHONG = value;
            }
        }
        public string GIAHAN
        {
            get
            {
                return _GIAHAN;
            }
            set
            {
                _GIAHAN = value;
            }
        }

        public DTO_PHIEUDATPHONG()
        {

        }

        public DTO_PHIEUDATPHONG(int MADP, int MADAILY, int _NGUOIDAT, string NGAYDEN,
        string NGAYDI, string YEUCAUDACBIET, string HINHTHUCDATPHONG, string NGAYDAT,
      int TIENCOC, int CHIPHIUOCTINH, int SONGUOI, int SOPHONG, string GIAHAN)
        {
            this.MADP = MADP;
            this.MADAILY = MADAILY;
            this.NGUOIDAT = NGUOIDAT;
            this.NGAYDEN = NGAYDEN;
            this.NGAYDI = NGAYDI;
            this.YEUCAUDACBIET = YEUCAUDACBIET;
            this.HINHTHUCDATPHONG = HINHTHUCDATPHONG;
            this.NGAYDAT = NGAYDAT;
            this.TIENCOC = TIENCOC;
            this.CHIPHIUOCTINH = CHIPHIUOCTINH;
            this.SONGUOI = SONGUOI;
            this.SOPHONG = SOPHONG;
            this.GIAHAN = GIAHAN;
        }
    }
}
