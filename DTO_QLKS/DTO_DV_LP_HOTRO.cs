using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DV_LP_HOTRO
    {
        private int _MALP;
        private int _MADVTC;


        //
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

        public DTO_DV_LP_HOTRO()
        {

        }

        public DTO_DV_LP_HOTRO(int MALP, int MADVTC)
        {
            this.MADVTC = MADVTC;
            this.MALP = MALP;
        }

    }
}
