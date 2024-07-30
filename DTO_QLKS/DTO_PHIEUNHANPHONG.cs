using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_PHIEUNHANPHONG
    {
        private int _MAPNP;
        private int _KHACHNHANPHONG;
        private int _MADATPHONG;
        private string _THOIDIEMNHAN;
        private int _MAPHONG;
        private int _NGUOILAP;


        //
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
        public int KHACHNHANPHONG
        {
            get
            {
                return _KHACHNHANPHONG;
            }
            set
            {
                _KHACHNHANPHONG = value;
            }
        }
        public int MADATPHONG
        {
            get
            {
                return _MADATPHONG;
            }
            set
            {
                _MADATPHONG = value;
            }
        }
        public string THOIDIEMNHAN
        {
            get
            {
                return _THOIDIEMNHAN;
            }
            set
            {
                _THOIDIEMNHAN = value;
            }
        }
        public int MAPHONG
        {
            get
            {
                return _MAPHONG;
            }
            set
            {
                _MAPHONG = value;
            }
        }
        public int NGUOILAP
        {
            get
            {
                return _NGUOILAP;
            }
            set
            {
                _NGUOILAP = value;
            }
        }

        public DTO_PHIEUNHANPHONG()
        {

        }

        public DTO_PHIEUNHANPHONG(int MAPNP,int PHIEUDATOHONG, int KHACHNHANPHONG, string THOIDIEMNHANPHONG, int MAPHONG,
                                    int NGUOILAP)
        {
            this.MAPNP = MAPNP;
            this.MADATPHONG = PHIEUDATOHONG;
            this.KHACHNHANPHONG = KHACHNHANPHONG;
            this.THOIDIEMNHAN = THOIDIEMNHAN;
            this.MAPHONG = MAPHONG;
            this.NGUOILAP = NGUOILAP;
        }

    }
}
