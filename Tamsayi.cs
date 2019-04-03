using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyadaki_hakikat
{
    class Tamsayi : Sayi
    {
        private int deger;

        public int Deger { get => deger;}

        public Tamsayi(String yenigirdi)
        {
            this.Girdi = yenigirdi;
            this.deger = Int32.Parse(Girdi);
        }

        
    }
}
