using System;

namespace dosyadaki_hakikat
{
    class Noktalisayi : Sayi
    {

        public Noktalisayi(String yenigirdi)
        {
            this.Girdi = yenigirdi;
            this.Deger = Double.Parse(Girdi);
        }
    }
}
