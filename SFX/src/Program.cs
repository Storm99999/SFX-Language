using SFX.src.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("There's no .sfx file provided");
                Console.ReadLine();
                return;
            }
            else
            {
                if (args[0].Contains(".sfx"))
                {
                    Console.WriteLine("Compiling " + args[0]);
                    Thread.Sleep(1000);
                    string contextOfFile = ReadServiceProvider.ReadContext(args[0]);

                }
            }
        }
    }
}
