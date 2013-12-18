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
    }
}
