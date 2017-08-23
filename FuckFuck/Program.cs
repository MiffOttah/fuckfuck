using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckFuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string program;
            if (args.Length >= 1)
            {
                program = File.ReadAllText(args[0]);
            }
            else
            {
                program = Console.In.ReadToEnd();
            }

            var interperter = new FuckFuckInterperter(program);
            interperter.Execute();
        }
    }
}
