using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DV_TAICHO
    {
        private int _MADVTC;
        private string _TENDV;
        private string _DONVITINH;
        private Decimal _GIA;
        private Decimal _PHITAMTHOI;


        //
        public int MADVTC
        {
            get
            {
                return _MADVTC;
            }
            set
            {
                _MADVTC = value;
            }
        }
        public String TENDV
        {
            get
            {
                return _TENDV;
            }
            set
            {
                _TENDV = value;
            }
        }
        public string DONVITINH
        {
            get
            {
                return _DONVITINH;
            }
            set
            {
                _DONVITINH = value;
            }
        }
        public Decimal GIA
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
        public Decimal PHITAMTHOI
        {
            get
            {
                return _PHITAMTHOI;
            }
            set
            {
                _PHITAMTHOI = value;
            }
        }

        public DTO_DV_TAICHO()
        {

        }

        public DTO_DV_TAICHO(int MADVTC, string TENDV, string DONVITINH, Decimal GIA, Decimal PHITAMTHOI)
        {
            this.MADVTC = MADVTC;
            this.TENDV = TENDV;
            this.DONVITINH = DONVITINH;
            this.GIA = GIA;
            this.PHITAMTHOI = PHITAMTHOI;
        }

    }
}
