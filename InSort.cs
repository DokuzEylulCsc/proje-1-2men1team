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

        public InSort(List<Tamsayi> girdi)
        {           
            foreach (Tamsayi i in girdi)//sayi listindeki her elemanın degerini al listeye ekle pdf nedenlerinden dolayi tek bir sayi girdisi yerine tamsayi ve noktali sayı ayri <polymorphism yeeeeey>
            {
                double a = i.Deger;
                this.sorted.Add(a);
            }                    
        }

        public InSort(List<Noktalisayi> girdi)
        {
            foreach (Noktalisayi i in girdi)
            {
                double a = i.Deger;
                this.sorted.Add(a);
            }
        }

        public List<Double>  getsorted()
        {
            
            return Sorted;
        }
        
    }
}
