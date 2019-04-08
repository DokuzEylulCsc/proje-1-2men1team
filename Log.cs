using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dosyadaki_hakikat
{
    class Log
    {
        

        static public void newlog(string stuff)
        {
            DateTime localDate = DateTime.Now;
            string path = @"Logs.log";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("L0GFILE");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(localDate.ToString() + stuff);
            }

        }

        public static void readlogfile(string path)
        {
            string[] lines;

            try
            {
                lines = File.ReadAllLines(path);
                foreach (string i in lines)
                {
                    Console.WriteLine(i);
                }

            }
            catch (Exception exp)
            {
                newlog(exp.ToString());
                Console.WriteLine("Lutfen log dosyası yolunu giriniz");
                String newthing = Console.ReadLine();

                readlogfile(newthing);
            }
         }
    }
}
