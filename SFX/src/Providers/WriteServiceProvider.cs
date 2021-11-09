using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX.src.Providers
{
    internal class WriteServiceProvider
    {
        public static void WriteContext(string contextFile, string context)
        {
            StreamWriter stream = new StreamWriter(contextFile);
            stream.Write(context);
            stream.Close();
        }
    }
}
