using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_HONGHOC
    {
        private int _MAHONGHOC;
        private int _MAPNP;
        private int _MAVATCHAT;
        private int _SOLUONG;
        /* ======== GETTER/SETTER ======== */
        public int MAHONGHOC
        {
            get
            {
                return _MAHONGHOC;
            }

            set
            {
                _MAHONGHOC = value;
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
        public int MAVATCHAT
        {
            get
            {
                return _MAVATCHAT;
            }

            set
            {
                _MAVATCHAT = value;
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

        /* === Constructor === */
        public DTO_HONGHOC()
        {

        }

        public DTO_HONGHOC(int mahhoc, int mapnp, int mavchat, int soluong)
        {
            this._MAHONGHOC = mahhoc;
            this._MAPNP = mapnp;
            this._MAVATCHAT = mavchat;
            this._SOLUONG = soluong;
        }
    }
}
