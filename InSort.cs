using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyadaki_hakikat
{
    class InSort
    {
        private List<Double> sorted = new List<double>();
        public List<Double> Sorted { get => sorted; }//disaridan sorted sadece okunmalı 

        public InSort(List<Sayi> girdi)
        {
            

            foreach (Sayi i in girdi)//sayi listindeki her elemanın degerini al listeye ekle ve sırala
            {
                double a = i.Deger;
                this.sorted.Add(a);
            }

             sorted.Sort();            
        }

        public List<Double>  getsorted()
        {

            return Sorted;
        }
        
    }
}
