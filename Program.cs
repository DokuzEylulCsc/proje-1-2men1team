using System;
namespace dosyadaki_hakikat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sinesfromfile;
            
            if (args.Length >= 2 && args[0] == "-L")
            {
                Log.readlogfile(args[1]);//-L ile loglari oku
                Environment.Exit(0);
            }

           
            try
            {
                sinesfromfile = Dosya_Islemleri.Read_File(args[0]);
                
            }
            catch (Exception exp)
            {
                Log.newlog(exp.ToString());
                sinesfromfile = Dosya_Islemleri.Read_File("");
            }

            Dosya_Islemleri.sendtosort(Dosya_Islemleri.findstuff(sinesfromfile));
            InSort sorter = new InSort(Dosya_Islemleri.Tamlist, Dosya_Islemleri.Noktalilist);
           
            sorter.getsorted();
            Console.ReadLine();

           
        }
    }
}
