using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX.src.Language
{
    internal class Functions
    {
        public static void GET(string code)
        {
            string[] parsed = code.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string s in parsed)
            {
                if (s.Contains("puts "))
                {
                    Console.WriteLine(s.Replace("puts ", ""));

                }
            }
        }
    }
}
