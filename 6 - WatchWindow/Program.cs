using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace WatchWindow
{
    public class C
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeStamp { get; set; } 

        public C(int id)
        {
            this.Id = id;
            this.Name = new string(Convert.ToChar('A' + id), 3);
            this.TimeStamp = DateTime.Now;
        }

		public override string ToString()
		{
			return string.Format("{0} - {1} - {2}", Id, Name, TimeStamp.ToLongTimeString());
		}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<C>();
            for (int i = 0; i < 50; i++)
            {
                a.Add(new C(i));
                Thread.Sleep((100));
            }

            Debugger.Break();
        }
    }
}
