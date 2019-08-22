using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1Genericity
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<Animal> animals = new List<Cat>();
        //    ArrayList arrayList = new ArrayList();
        //    arrayList.Add("HellowWorld");
        //    arrayList.Add(3);
        //    Dictionary<string, int> d = new Dictionary<string, int>();
        //    
        //    arrayList.Add(new MemoryStream());
        //    List<string> stringList = MakeList<string>("first", "second");
        //    List<string> stringList = MakeList("first", "second");
        //}

        static void Main()
        {
            string s1 = "abc";
            char[] chars = { 'a', 'b', 'c' };
            string s2 = new string(chars);
            Console.WriteLine(s1 == s2);
            TestCompary<string>(s1, s2);
            Console.ReadKey();
        }

        static void TestCompary<T>(T t1, T t2) where T : class
        {
            Console.WriteLine(t1 == t2);
        }

        //static void TestComparyVal<T>(T t1, T t2) where T : struct
        //{
        //    Console.WriteLine(t1 == t2);
        //}

        public T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        //static List<T> MakeList<T>(T first, T secone)
        //{ }
    }

    class Animal
    { }
    class Cat : Animal
    { }
    class Turtle : Animal { }

    //class Manageer<T> where T:class
    //struct RefSample<U> where U : class
    //class ValSample<T> where T : struct
    //class Sample<T> where T : Stream
    //    Sample<Stream>

    //class Sample<T> where T : IDisposable
    //    Sample<SalConnection>

    //class Sample<T> where T : IComparable<T>
    //   Sample<int>

    //class Sample<T> where T : Stream, IEnumerable<string>, IComparable<int>
    //class Sample<T> where T :Stream,ArrayList,IComparable<int>

    //class Sample<T, U> where T : class where U : class, T


}
