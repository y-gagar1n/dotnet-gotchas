using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadResolution
{
    class C
    {
		public static void M(object x)
		{
			System.Console.WriteLine("static M(object)");
		}
		public void M(string s)
        {
			System.Console.WriteLine("M(string)");
        }
    }
    class Program
    {
        static void Main()
        {
            C c = new C();
            C.M("hello");
        }
    }
}
