using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10___CompilerBugs
{
    public interface ICompilerBug
    {
        void ShowMeTheBug();
    }

    public class Bug1 : ICompilerBug
    {
        public class Foo
        {
            public void Bar(params string[] something)
            {
                Console.WriteLine("Bar1");
            }

            public void Bar<M>(M something)
            {
                Console.WriteLine("Bar2");
            }

			//public void Bar(string something, object somethingElse = null)
			//{
			//	Console.WriteLine("Bar3");
			//}
        }

        public void ShowMeTheBug()
        {
            var a = new Foo();
            a.Bar("Who are you?");
        }
    }

	//public class Bug2 : ICompilerBug
	//{
	//	static bool M(out int x)
	//	{
	//		x = 123;
	//		return true;
	//	}
	//	static int N(dynamic d) //меняем bool на dynamic и получаем use of unassigned variable y
	//	{
	//		int y;
	//		if (d || M(out y))
	//			y = 10;
	//		return y;
	//	}

	//	public void ShowMeTheBug()
	//	{
	//	}
	//}

	public class Bug3 : ICompilerBug
	{
		public struct A
		{
			public static implicit operator B(A input)
			{
				Console.WriteLine("A to B");
				return new B();
			}

			public static implicit operator C(A input)
			{
				Console.WriteLine("A to C");
				return new C();
			}
		}

		public struct B
		{
			public static implicit operator C(B input)
			{
				Console.WriteLine("B to C");
				return new C();
			}
		}

		public struct C { }

		public void ShowMeTheBug()
		{
			A? a = new A();
			B? b = new B();
			C? c = new C();

			//C cNotNull = new C();

			//var q = ( B)a;

			var f = ((B?)a ?? b) ?? c;

		}
	}




    class Program
    {
        static void Main(string[] args)
        {
            ICompilerBug bug;

            bug = new Bug3();

            bug.ShowMeTheBug();
        }
    }
}
