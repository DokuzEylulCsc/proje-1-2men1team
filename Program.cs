using System;
namespace dosyadaki_hakikat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sinesfromfile;
            

           
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
           
            sorter.getsorted();
            Console.ReadLine();

           
        }
    }
}
