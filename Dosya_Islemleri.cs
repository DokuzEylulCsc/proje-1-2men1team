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






        public static void Dosyaoku(string doc_path)
        {
            FileStream fileStream = new FileStream(doc_path, FileMode.Open, FileAccess.Read);
            StreamReader swstream = new StreamReader(fileStream);

        }
    }
}
