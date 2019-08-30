using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1Nullable
{
    [Description("TrueFalseOperators")]
    class TrueFalseOperators
    {
        static void Main()
        {
            //Person p1 = new Person() { id = 1 };
            //Person p2 = new Person() { id = -1 };
            //if (p1)
            //{
            //    Console.WriteLine("p1");
            //}
            //if (p2)
            //{
            //    Console.WriteLine("p2");
            //}

            //Test t1 = new Test() { id = 1 };
            //Test t2 = new Test() { id = -1 };
            //if (t1)
            //{
            //    Console.WriteLine("t1");
            //}
            //if (t2)
            //{
            //    Console.WriteLine("t2");
            //}

            //Test? t3 = new Test?();
            //t3 = t1;
            //Test? t4 = new Test?();
            //t4 = t2;
            //if (t3)
            //{
            //    Console.WriteLine("t1");
            //}
            //if (t4)
            //{
            //    Console.WriteLine("t2");
            //}

            int? a = null;
            int? b = null;
            int? c = 5;
            Console.WriteLine(a??b??c);

        }
    }

    class Person
    {
        public int id { get; set; }

        public static bool operator true(Person op)
        {
            return op.id >= 0;
        }

        public static bool operator false(Person op)
        {
            return op.id < 0;
        }
    }

    struct Test
    {
        public int id { get; set; }

        public static bool operator true(Test op)
        {
            return op.id >= 0;
        }

        public static bool operator false(Test op)
        {
            return op.id < 0;
        }
    }
}
