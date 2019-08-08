using System;
namespace _2._1Delegate
{
    public delegate void StringProcess(string input);
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("tom");
            StringProcess tomSay = new StringProcess(tom.Say);
            Person jon = new Person("jon");
            StringProcess jonSay = new StringProcess(jon.Say);
            StringProcess jonWrite = new StringProcess(jon.Write);

            StringProcess noteBookNote = new StringProcess(NoteBook.Note);

            tomSay.Invoke("hello");
            jonSay.Invoke("hi");
            jonWrite.Invoke("hha");
            noteBookNote.Invoke("good good study");

            //StringProcess tomSayCopy = tomSay;
            //tomSay = (StringProcess)Delegate.Combine(jonSay, tomSay, noteBookNote, jonWrite);
            //tomSay.Invoke("all");
            //tomSayCopy.Invoke("not change");
            //tomSay = (StringProcess)Delegate.Remove(tomSay, tomSay);
            //tomSay.Invoke("after remove");

            StringProcess tomSayCopy = tomSay;
            tomSay = jonSay + tomSay + noteBookNote + jonWrite;
            tomSay.Invoke("all");
            tomSayCopy.Invoke("not change");
            tomSay -= jonSay;
            tomSay -= jonSay;
            tomSay.Invoke("after remove");

            Printer printer = new Printer();
            PrintSetting.SetPrintEvent(printer);
            printer.PrintEvent("Printed");

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public void Say(string message)
        {
            Console.WriteLine(Name + " Say: " + message);
        }

        public void Write(Object message)
        {
            Console.WriteLine(Name + " Say: " + message);
        }
    }

    static class NoteBook
    {
        public static void Note(string message)
        {
            Console.WriteLine(message);
        }
    }
}
