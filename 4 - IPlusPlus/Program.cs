using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPlusPlus
{
    static class X
    {
        public static void M(this int x)
        {
            Console.WriteLine(C.c);
            Console.WriteLine(x);
        }
    }
    class C
    {
        public static int c = 0;
        public static void Main()
        {
            (c++).M();
        }
    }
}
