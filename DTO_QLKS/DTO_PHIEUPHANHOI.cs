using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHIEUPHANHOI
    {
        private int _MAPH;
        private string _NOIDUNG;
        private int _MAPNP;
        private string _DANHGIA;

        /* ======== GETTER/SETTER ======== */
        public int MAPH
        {
            get
            {
                return _MAPH;
            }

            set
            {
                _MAPH =  value;
            }
        }
        public string NOIDUNG
        {
            get
            {
                return _NOIDUNG;
            }

            set
            {
                _NOIDUNG = value;
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
                _MAPNP = value;
            }
        }
        public string DANHGIA
        {
            get
            {
                return _DANHGIA;
            }

            set
            {
                _DANHGIA = value;
            }
        }
        /* === Constructor === */
        public DTO_PHIEUPHANHOI()
        {

        }

        public DTO_PHIEUPHANHOI(int maph, string ndung, int mapnp, string dgia)
        {
            this._MAPH = maph;
            this._NOIDUNG = ndung;
            this._MAPNP = mapnp;
            this._DANHGIA = dgia;
        }
    }
}
