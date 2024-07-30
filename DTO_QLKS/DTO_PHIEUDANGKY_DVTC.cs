using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHIEUDANGKY_DVTC
    {
        private int _MADVTC;
        private int _MAPNP;
        private DateTime _THOIDIEMSUDUNG;
        private DateTime _THOIDIEMDANGKY;


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
        public int MAPNP
        {
            get
            {
                return _MAPNP;
            }
            set
            {
                _MAPNP =  value;
            }
        }
        public DateTime THOIDIEMDANGKY
        {
            get
            {
                return _THOIDIEMDANGKY;
            }
            set
            {
                _THOIDIEMDANGKY = value;
            }
        }
        public DateTime THOIDIEMSUDUNG
        {
            get
            {
                return _THOIDIEMSUDUNG;
            }
            set
            {
                _THOIDIEMSUDUNG = value;
            }
        }

        public DTO_PHIEUDANGKY_DVTC()
        {

        }

        public DTO_PHIEUDANGKY_DVTC(int MADVTC, int MAPNP, DateTime THOIDIEMSUDUNG, DateTime THOIDIEMDANGKY)
        {
            this.MADVTC = MADVTC;
            this.MAPNP = MAPNP;
            this.THOIDIEMDANGKY = THOIDIEMDANGKY;
            this.THOIDIEMSUDUNG = THOIDIEMSUDUNG;
        }

    }
}
