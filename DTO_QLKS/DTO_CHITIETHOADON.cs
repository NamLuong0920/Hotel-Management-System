using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_CHITIETHOADON
    {
        private int _MAHOADON;
        private int _STT;
        private string _DV_CSVC;
        private int _SOLUONG;
        private decimal _THANHTIEN;

        /* ======== GETTER/SETTER ======== */
        public int MAHOADON
        {
            get
            {
                return _MAHOADON;
            }

            set
            {
                _MAHOADON = value;
            }
        }
        public int STT
        {
            get
            {
                return _STT;
            }

            set
            {
                _STT = value;
            }
        }
        public string DV_CSVC
        {
            get
            {
                return _DV_CSVC;
            }

            set
            {
                _DV_CSVC = value;
            }
        }
        public int SOLUONG
        {
            get
            {
                return _SOLUONG;
            }

            set
            {
                _SOLUONG = value;
            }
        }
        public decimal THANHTIEN
        {
            get
            {
                return _THANHTIEN;
            }

            set
            {
                _THANHTIEN = value;
            }
        }
        /* === Constructor === */
        public DTO_CHITIETHOADON()
        {

        }

        public DTO_CHITIETHOADON(int mahdon, int stt, string dvcsvc, int soluong, decimal thanhtien)
        {
            this._MAHOADON = mahdon;
            this._STT = stt;
            this._DV_CSVC = dvcsvc;
            this._SOLUONG = soluong;
            this._THANHTIEN = thanhtien;
        }
    }
}
