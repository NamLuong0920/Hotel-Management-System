using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_GIAHAN
    {
        private int _STT;
        private int _MADP;
        private int _THOIGIANGIAHAN;
        private string _TINHTRANGDUYET;
        
        /* ======== GETTER/SETTER ======== */
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
        public int THOIGIANGIAHAN
        {
            get
            {
                return _THOIGIANGIAHAN;
            }

            set
            {
                _THOIGIANGIAHAN = value;
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
        /* === Constructor === */
        public DTO_GIAHAN()
        {

        }

        public DTO_GIAHAN(int sttgh, int madp, int tggiahan, string ttduyet)
        {
            this._STT = sttgh;
            this._MADP = madp;
            this._THOIGIANGIAHAN = tggiahan;
            this._TINHTRANGDUYET = ttduyet;
        }
    }
}
