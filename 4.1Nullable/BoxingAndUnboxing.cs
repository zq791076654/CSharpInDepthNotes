using System;
using System.ComponentModel;

namespace _4._1Nullable
{
    [Description("BoxingAndUnboxing")]
    class BoxingAndUnboxing
    {
        static void Main()
        {
            //有值
            int? nullable = 5;

            //object是int的可装箱对象
            object boxed = nullable;
            Console.WriteLine(boxed.GetType());

            //拆箱成基础类型
            int normal = (int)boxed;
            Console.WriteLine(normal);

            //拆箱成可空类型
            nullable = (int?)boxed;
            Console.WriteLine(nullable);

            //无值
            nullable = new int?();

            //装箱成空引用
            boxed = nullable;
            Console.WriteLine(boxed == null);

            //拆箱成可空类型
            nullable = (int?)boxed;
            DateTime? t = (DateTime?)boxed;
            Console.WriteLine(nullable.HasValue);
            Console.WriteLine(t.HasValue);
        }
    }
}
