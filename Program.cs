using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyadaki_hakikat
{
    class Program
    {
        static void Main(string[] args)
        {
            //test meretleri
            Tamsayi patates = new Tamsayi("1");
            Noktalisayi test = new Noktalisayi("2.3");
            Console.WriteLine(patates.Deger);
            Console.WriteLine(test.Deger);
            Console.ReadLine();
        }
    }
}
