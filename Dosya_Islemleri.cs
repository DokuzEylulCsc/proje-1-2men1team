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

        static private string[] lines;

    //    public string[] Lines { get => lines;}
        

      

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

        static void findstuff(String[] stuff)
        {
            
            foreach (string a in stuff)
            {
                if (Regex.IsMatch(a, @"^-?[0-9]\d*(\.\d+)?$"))
                {
                    Console.WriteLine(a);
                }

            }
            Console.ReadLine();


            
        }




    }
}



 