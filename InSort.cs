using System;
using System.Collections.Generic;

namespace dosyadaki_hakikat
{
    class InSort
    {
        private List<Double> sorted = new List<double>();
        public List<Double> Sorted {
            get
            {
                sorted.Sort(); //sayilari sirala belki gelecekte default yerine farkli bir algoritma kullanılabilir
                return sorted;
            }
        }//disaridan sorted sadece okunmalı 

        

        public InSort(List<Tamsayi> girditam, List<Noktalisayi> girdinok)
        {           
            foreach (Tamsayi i in girditam)//sayi listindeki her elemanın degerini al listeye ekle pdf nedenlerinden dolayi tek bir sayi girdisi yerine tamsayi ve noktali sayı ayri <polymorphism yeeeeey>
            {
                double a = i.Deger;
                this.sorted.Add(a);
            }

            foreach (Noktalisayi i in girdinok)
            {
                double a = i.Deger;
                this.sorted.Add(a);
            }

        }

      /*  public InSort(List<Noktalisayi> girdi)
        {
            foreach (Noktalisayi i in girdi)
            {
                double a = i.Deger;
                this.sorted.Add(a);
            }
        }
        */
        public List<Double>  getsorted()
        {
            Console.WriteLine("--------Siralanmis Veriler------");

            foreach (double a in Sorted)
            {
                Console.WriteLine(a.ToString());
            }
            return Sorted;
        }
        
    }
}
