using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyadaki_hakikat
{
    class Noktalisayi : Sayi
    {
        private double deger;

        public double Deger { get => deger; }

        public Noktalisayi(String yenigirdi)
        {
            this.Girdi = yenigirdi;
            this.deger = Double.Parse(Girdi);
        }
    }
}
