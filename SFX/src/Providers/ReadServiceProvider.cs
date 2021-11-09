using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX.src.Providers
{
    internal class ReadServiceProvider
    {
        public static string ReadContext(string str)
        {
            StreamReader stream = new StreamReader(str);
            string context = stream.ReadToEnd();
            return context;
        }
    }
}
