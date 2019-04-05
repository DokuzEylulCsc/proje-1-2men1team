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
            //test meretleri silmeyi unutma
            Random rand = new Random();
            List<Tamsayi> dickweed = new List<Tamsayi>();
            int tum;
            
            for (int i = 0; i < 12; i++)
            {
                tum = rand.Next(1000);
                dickweed.Add(new Tamsayi(tum.ToString()));
                
            }



            

            Tamsayi patates = new Tamsayi("1.2");

            Noktalisayi test = new Noktalisayi("2.3");
            Noktalisayi test2 = new Noktalisayi("-2.3");
            Tamsayi patates2 = new Tamsayi("-23");
            //dickweed.Add(test2);
            Console.WriteLine(patates2.Deger);
            Console.WriteLine(test2.Deger);
            InSort sortedthing = new InSort(dickweed);
            Console.WriteLine(sortedthing.Sorted);
            Console.ReadLine();
            // test meretleri son


        }
    }
}
