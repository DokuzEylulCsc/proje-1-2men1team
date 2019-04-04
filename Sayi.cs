using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyadaki_hakikat
{
    abstract class Sayi
    {
        string girdi;//dosyadan veriyi string olarak alacak

        public string Girdi { get => girdi; set => girdi = value; }
        public double Deger { get; set; }
    }
}
