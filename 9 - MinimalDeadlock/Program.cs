using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinimalDeadlock
{
    class Program
    {
        static Program()
        {
            var thread = new System.Threading.Thread(Initialize);
            Console.WriteLine("START");
            thread.Start();
            thread.Join();
            Console.WriteLine("FINISH");
        }

        static void Initialize()
        { Console.WriteLine("INITIALIZE"); }

        static void Main()
        { }
    }
}
