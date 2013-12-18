using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadResolution
{
    class Animal { }
    class Mammal : Animal { }
    class Reptile : Animal { }

	class Giraffe : Mammal { }


    class Program
    {
        static void Foo<T>(T t) where T : Reptile
        {
            Console.WriteLine("Generic reptile resolution");
        }
        static void Foo(Animal animal)
        {
            Console.WriteLine("Animal resolution");
        }

        static void Main()
        {
            var g = new Giraffe();
	        Foo(g);
        }
    }
}