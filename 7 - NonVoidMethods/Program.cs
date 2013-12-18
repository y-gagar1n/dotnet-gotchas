using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7___NonVoidMethods
{
    class Program
    {
        static int Foo()
        {
            const bool f = true;
            while (f)
            {
                if (1 == 1) continue;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
