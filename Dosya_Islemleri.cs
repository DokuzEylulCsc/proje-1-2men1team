using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dosyadaki_hakikat
{
    class Dosya_Islemleri
    {
        public static void Paramcontrol()
        {

        }

      

        public static void Read_File()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Arty0m\Desktop\aq.txt"); 
            // Okunacak text dosyası yolu

           string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");

            //  
            System.Console.WriteLine("Contents of WriteLines2.txt = ");

            foreach (string line in lines)
            {
              
                Console.WriteLine("\n" + line);
            }

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}



 