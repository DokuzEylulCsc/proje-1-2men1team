using System;
namespace dosyadaki_hakikat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sinesfromfile;
            

            //test meretleri silmeyi unutma
            try
            {
                sinesfromfile = Dosya_Islemleri.Read_File(args[0]);
                //sinesfromfile = Dosya_Islemleri.Read_File(");
            }
            catch
            {
                sinesfromfile = Dosya_Islemleri.Read_File("");
            }

            Dosya_Islemleri.sendtosort(Dosya_Islemleri.findstuff(sinesfromfile));
          //  InSort sorter = new InSort(Dosya_Islemleri.Tamlist);
          //  sorter(Dosya_Islemleri.Noktalilist);
            Console.ReadLine();

            // test meretleri son
        }
    }
}
