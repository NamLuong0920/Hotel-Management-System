using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_APDUNGCHINHSACH
    {
        private int _MACS;
        private int _MAPDP;
        private DateTime _THOIGIANBATDAU;
        private DateTime _THOIGIANKETTHUC;

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
        public int MAPDP
        {
            get
            {
                return _MAPDP;
            }

            set
            {
                _MAPDP = value;
            }
        }
        public DateTime THOIGIANBATDAU
        {
            get
            {
                return _THOIGIANBATDAU;
            }

            set
            {
                _THOIGIANBATDAU = value;
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

        /* === Constructor === */
        public DTO_APDUNGCHINHSACH()
        {

        }

        public DTO_APDUNGCHINHSACH(int macs, int mapdp, DateTime tgbd, DateTime tgkt)
        {
            this._MACS = macs;
            this._MAPDP = mapdp;
            this._THOIGIANBATDAU = tgbd;
            this._THOIGIANKETTHUC = tgkt;
        }
    }
}
