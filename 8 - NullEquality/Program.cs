using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8___NullEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = null;

            Console.WriteLine(a >= b);
            Console.WriteLine(a == b);
        }
    }
}
