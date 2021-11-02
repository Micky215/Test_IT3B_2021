using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opakovaniNaTest
{
    class Auto
    {
        private int naklad;

        public int Naklad { get => naklad;  }
        public string Znacka { get; }
        public int Nosnost { get; }

        public Auto(int naklad, string znacka, int nosnost)
        {
            Znacka = znacka;
            Nosnost = nosnost;
        }

        public int Nalozit(int naklad)
        {
            var misto = Nosnost - Naklad;
            if (misto < naklad)
            {
                this.naklad = misto;
                return misto;
            }
            else
            {
                this.naklad = naklad;
                return naklad;
            }
        }

        public void Vylozit(int naklad)
        {

        }



    }
}
