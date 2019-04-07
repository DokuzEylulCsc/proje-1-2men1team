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
                
            }
            catch
            {
                sinesfromfile = Dosya_Islemleri.Read_File("");
            }

            Dosya_Islemleri.sendtosort(Dosya_Islemleri.findstuff(sinesfromfile));
            InSort sorter = new InSort(Dosya_Islemleri.Tamlist, Dosya_Islemleri.Noktalilist);
            //  sorter(Dosya_Islemleri.Noktalilist);
            sorter.getsorted();
            Console.ReadLine();

            // test meretleri son
        }
    }
}
