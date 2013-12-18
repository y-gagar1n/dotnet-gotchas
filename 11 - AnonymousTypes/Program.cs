using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11___AnonymousTypes
{
	class Program
	{
		static void Main()
		{
			var o1 = new {a = 1, b = 2};
			var o2 = new {a = 3, b = 4};

			Console.WriteLine(o1.GetType() == o2.GetType());

			var o3 = new { a = 1, b = 2 };
			var o4 = new { _a = 3, _b = 4 };

			Console.WriteLine(o3.GetType() == o4.GetType());

			var o5 = new { a = 1, b = 2 };
			var o6 = new { a = 1, b = 2.0 };

			Console.WriteLine(o5.GetType() == o6.GetType());

			var o7 = new { a = 1, b = 2 };
			var o8 = new { b = 2, a = 1 };

			Console.WriteLine(o7.GetType() == o8.GetType());
		}

	}
}
