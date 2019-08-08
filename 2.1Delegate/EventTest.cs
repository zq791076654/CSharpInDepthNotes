using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1Delegate
{
    public class Printer
    {
        public StringProcess PrintEvent;
        void Print(string message)
        {
            PrintEvent(message);
        }
    }

    public static class PrintSetting
    {
        public static void SetPrintEvent(Printer printer)
        {
            ExamPaper examPaper = new ExamPaper();
            printer.PrintEvent += examPaper.ExamPaperPrint;
            printer.PrintEvent += Contract.ContractPrint;
        }
    }

    public class ExamPaper
    {
        public void ExamPaperPrint(string message)
        {
            Console.WriteLine("ExamPaper " + message);
        }
    }

    public static class Contract
    {
        public static void ContractPrint(string message)
        {
            Console.WriteLine("Contract " + message);
        }
    }
}
