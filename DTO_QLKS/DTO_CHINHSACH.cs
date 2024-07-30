using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_CHINHSACH
    {
        private int _MACS;
        private string _TENCS;
        private DateTime _THOIGIANAPDUNG;

        /* ======== GETTER/SETTER ======== */
        public int MACS
        {
            get
            {
                return _MACS;
            }

            set
            {
                _MACS = value;
            }
        }
        public string TENCS
        {
            get
            {
                return _TENCS;
            }

            set
            {
                _TENCS =  value;
            }
        }
        public DateTime THOIGIANAPDUNG
        {
            get
            {
                return _THOIGIANAPDUNG;
            }

            set
            {
                _THOIGIANAPDUNG = value;
            }
        }

        /* === Constructor === */
        public DTO_CHINHSACH()
        {

        }

        public DTO_CHINHSACH(int macs, string tencs, DateTime tgad)
        {
            this._MACS = macs;
            this._TENCS = tencs;
            this._THOIGIANAPDUNG = tgad;
        }
    }
}
