using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultLiterals
{
    public class DefaultLiteralSample
    {
        public static bool OldStyle()
        {
            var x = default(int);
            var y = default(object);
            return x.Equals(y);
        }
        public static int OldMethodWithArgs(int a = default(int), object b = default(object))
        {
            return default(int);
        }
    }
}
