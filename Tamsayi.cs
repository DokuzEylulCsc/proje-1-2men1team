using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyadaki_hakikat
{
    class Tamsayi : Sayi
    {
        //tam sayi ve noktali sayi classlari ozunde aynı ama whatever en kotu loglarda ikisinin de yuzdesini verebiliris

        public Tamsayi(String yenigirdi)
        {
            this.Girdi = yenigirdi;
            this.Deger = Double.Parse(Girdi);
        }

        
    }
}
