﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
