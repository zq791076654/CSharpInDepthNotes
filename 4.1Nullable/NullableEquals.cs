using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1Nullable
{
    [Description("NullableEquals")]
    class NullableEquals
    {
        static void Main()
        {
            int? a = new int?();
            int? b = new int?();
            DateTime? t = new DateTime?();
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(t));

            b = 5;
            Console.WriteLine(a.Equals(b));

            a = 5;
            b = null;
            Console.WriteLine(a.Equals(b));
            b = 5;
            Console.WriteLine(a.Equals(b));
            t = DateTime.Now;
            Console.WriteLine(a.Equals(t));

        }
    }
}
