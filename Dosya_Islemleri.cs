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

        static private string[] lines;

        public string[] Lines { get => lines;}
        

      

        public static void Read_File(String dest)
        {            
            // Okunacak text dosyası yolu
                       

            try{
                lines = File.ReadAllLines(dest);
               
            }
            catch (Exception except)
            {
                Console.WriteLine(except);
                String newthing = Console.ReadLine();
                Read_File(newthing);
            }



        }
    }
}



 