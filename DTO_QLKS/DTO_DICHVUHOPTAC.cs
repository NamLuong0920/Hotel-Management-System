using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_DICHVUHOPTAC
    {
        private int _MADVHT;
        private int _MADOITACDV;
        private string _TENDV;
        private Decimal _GIA;


        //
        public int MADVHT
        {
            get
            {
                return _MADVHT;
            }
            set
            {
                _MADVHT = value;
            }
        }
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
        public string TENDV
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

        public DTO_DICHVUHOPTAC()
        {

        }

        public DTO_DICHVUHOPTAC(int MADVHT, int MADOITACDV, string TENDV, Decimal GIA)
        {
            this.MADVHT = MADVHT;
            this.MADOITACDV = MADOITACDV;
            this.TENDV = TENDV;
            this.GIA = GIA;
        }

    }
}
