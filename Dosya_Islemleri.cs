using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace dosyadaki_hakikat
{
    class Dosya_Islemleri

    {

        static private string[] lines; //{ get => lines; set => lines = value; }        

        public static void Read_File(String dest)
        {            
            // Okunacak text dosyası yolu                       
            try{
                lines = File.ReadAllLines(dest);
                findstuff(lines);
               
            }
            catch (Exception except)
            {
                Console.WriteLine(except);
                String newthing = Console.ReadLine();
                Read_File(newthing);
            }
        }

        static List<string> findstuff(String[] stuff)//sayıları eleyen fonksiyon sadece bu class icinde cagirilsin
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
            Console.WriteLine("%" + ((count / stuff.Length) * 100).ToString() + " sayi");
             

            Console.ReadLine();

            return numbers;
        }




    }
}



 