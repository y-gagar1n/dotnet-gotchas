using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqMethods
{
    public class Foo<T>
    {
        private IEnumerable<T> range;
        public Foo(IEnumerable<T> range)
        {
            this.range = range;
        }
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
			foreach (var i in range)
			{
				if (predicate(i)) yield return i;
			}
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //var range = Enumerable.Range(0, 10);
            var range = new Foo<int>(Enumerable.Range(0, 10));
            
            var filtered = from x in range where x%2 == 0 select x;

            foreach (var i in filtered)
            {
                Console.WriteLine(i);
            }
        }
    }
}
