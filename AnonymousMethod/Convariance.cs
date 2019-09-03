using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{

    /// <summary>
    /// 返回值的协变性
    /// </summary>
    [Description("Convariance")]
    class Convariance
    {
        delegate Stream GetStream();
        static MemoryStream GetMemoryStream()
        {
            Console.WriteLine("new ms");   
            return new MemoryStream();
        }

        
        static void Main()
        {
            GetStream getStream = GetMemoryStream;
            Stream s = getStream();
            //编译器认为返回的是Stream，从父类到子类要强制转换
            //MemoryStream ms = (MemoryStream)getStream();
            Console.ReadKey();
        }


    }
}
