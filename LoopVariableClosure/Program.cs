using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopVariableClosure
{
    class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();
            for (int i = 0; i < 10; i++)
            {
                actions.Add(() => Console.WriteLine(i));
            }
            
            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
