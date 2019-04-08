using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace dosyadaki_hakikat
{
    class Dosya_Islemleri

    {

        static private string[] lines; //{ get => lines; set => lines = value; }        
        static public string[] Lines { get => lines; }
        static public List<Noktalisayi> Noktalilist { get => noktalilist;}
        static public List<Tamsayi> Tamlist { get => tamlist;}

        private static List<Noktalisayi> noktalilist = new List<Noktalisayi>();
        private static List<Tamsayi> tamlist = new List<Tamsayi>();


        public static string[] Read_File(String dest)
        {
             
            // Okunacak text dosyası yolu                       
            try
            {
                lines = File.ReadAllLines(dest);
                return Lines;
                //findstuff(lines);
               
            }
            catch (Exception except)
            {
                //Console.WriteLine(except);
                Log.newlog(except.ToString());
                Console.WriteLine("Lutfen dosya yolunu giriniz");
                String newthing = Console.ReadLine();
                
                return Read_File(newthing);
            }
        }

        public static List<string> findstuff(String[] stuff)//sayıları eleyen fonksiyon sadece bu class icinde cagirilsin
        {
            int count = 0;
            List<string> numbers = new List<string>();

            foreach (string a in stuff)
            {
                if (Regex.IsMatch(a, @"^-?[0-9]\d*(\.\d+)?$"))//kara buyu ile sayıları ayırt et 
                {
                    count = count + 1;
                    Console.WriteLine(a);
                    numbers.Add(a);
                }
            }

            Console.WriteLine(stuff.Length.ToString() + " satir icinden ");
            Console.WriteLine(count.ToString() +  " sayi bulundu ");
            Console.WriteLine("%" + ((count * 1.0 / stuff.Length *1.0) * 100).ToString() + " sayi");


           //Console.ReadLine();
           // sendtosort(numbers);

            return numbers;
        }

        public static void sendtosort(List<string> numbers)
        {


            foreach (string i in numbers)
            {
                if (Regex.IsMatch(i, @"[-]|[0-9]{0,}[.]\d{0,}"))//negatif ya da pozitif noktalı olanları ayırt et 
                {
                    if(i.StartsWith("-"))//this is horrible
                    {
                        string z = i.Substring(1);
                        if (Regex.IsMatch(z, @"[0-9]{0,}[.]\d{0,}"))
                        {
                            noktalilist.Add(new Noktalisayi(i));
                            Console.WriteLine("noktali: " + i);
                        }
                        else
                        {
                            tamlist.Add(new Tamsayi(i));
                            Console.WriteLine("tam: " + i);
                        }
                    }
                    else
                    {
                        noktalilist.Add(new Noktalisayi(i));
                        Console.WriteLine("noktali: " + i);
                    }


                }
                else
                {
                    tamlist.Add(new Tamsayi(i));
                    Console.WriteLine("tam: " + i);

                }
            }
        }


    }
}



 