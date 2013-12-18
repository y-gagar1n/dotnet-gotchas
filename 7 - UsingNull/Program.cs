using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7___UsingNull
{
    class Program
    {
        static void Main(string[] args)
        {
            using (null)
            {
                Console.WriteLine("inside using");
            }
            Console.WriteLine("finished using");
        }
    }
}
