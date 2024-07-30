using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DOITACDICHVU
    {
        private int _MADOITACDV;
        private string _TENDOITAC;
        private string _SDT;
        private string _EMAIL;
        private string _DIACHI;


        //
        public int MADOITACDV
        {
            get
            {
                return _MADOITACDV;
            }
            set
            {
                _MADOITACDV = value;
            }
        }
        public string TENDOITAC
        {
            get
            {
                return _TENDOITAC;
            }
            set
            {
                _TENDOITAC = value;
            }
        }
        public string SDT
        {
            get
            {
                return _SDT;
            }
            set
            {
                _SDT = value;
            }
        }
        public string EMAIL
        {
            get
            {
                return _EMAIL;
            }
            set
            {
                _EMAIL = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return _DIACHI;
            }
            set
            {
                _DIACHI = value;
            }
        }

        public DTO_DOITACDICHVU()
        {

        }

        public DTO_DOITACDICHVU(int MADOITACDV, string TENDOITAC, string SDT, string EMAIL, string DIACHI)
        {
            this.MADOITACDV = MADOITACDV;
            this.TENDOITAC = TENDOITAC;
            this.SDT = SDT;
            this.EMAIL = EMAIL;
            this.DIACHI = DIACHI;
        }

    }
}
