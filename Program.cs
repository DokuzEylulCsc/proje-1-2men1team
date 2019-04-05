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
            try
            {
                Dosya_Islemleri.Read_File(args[0]);
            }
            catch
            {
                Dosya_Islemleri.Read_File("");
            }
            Console.ReadLine();
            // test meretleri son
        }
    }
}
