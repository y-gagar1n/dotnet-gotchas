using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThisEqualsNull
{
    public class SelfNullChecker
    {
        public bool ThisIsNull()
        {
            return this == null;
        }

		//public static bool operator ==(SelfNullChecker source, object target)
		//{
		//	return target == null;
		//}

		//public static bool operator !=(SelfNullChecker source, object target)
		//{
		//	return !(source == target);
		//}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var checker = new SelfNullChecker();
            Console.WriteLine(checker.ThisIsNull()); //FALSE

			//Type type = checker.GetType();
			//var method = type.GetMethod("ThisIsNull");
			//var d = (Func<bool>)(Delegate.CreateDelegate(typeof (Func<bool>), null, method));

			//Delegate.CreateDelegate(typeof (Func<bool>), null, method);
            
			//Console.WriteLine(d()); //TRUE
        }
    }
}
