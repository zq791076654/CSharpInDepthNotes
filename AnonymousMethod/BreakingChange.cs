using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    delegate void Test(string s);
    /// <summary>
    /// c#2.0支持了参数的逆变后产生的问题：
    /// 子类重载父类的方法，并且都与某个委托类型兼容，则会选择子类的方法,即使最匹配的参数在父类中
    /// </summary>
    [Description("BreakingChange")]
    public class BreakingChange
    {
        static void Main()
        {
            Test t = BreakingChangeChild.Print;
            t("s");
            Console.WriteLine();
        }
    }

    public class BreakingChangeParent
    {
        public static void Print(string s)
        {
            Console.WriteLine("Parent" + s);
        }
    }

    public class BreakingChangeChild : BreakingChangeParent
    {
        public static void Print(Object obj)
        {
            Console.WriteLine("Child" + obj);
        }
    }


}
