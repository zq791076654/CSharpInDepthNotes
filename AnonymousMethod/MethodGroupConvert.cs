using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AnonymousMethod
{
    [Description("MethodGroupConvert")]
    class MethodGroupConvert
    {
        static void Main()
        {
            Button button = new Button();
            button.Text = "Click me";
            //从方法组到到兼容委托类型实例的隐式转换
            button.Click += LogPlainEvent;
            //button.Click += GetEventHandler;
            button.MouseClick += LogMouseEvent;
            button.KeyPress += LogKeyEvent;

            Form form = new Form();
            form.AutoSize = true;
            form.Controls.Add(button);
            Application.Run(form);
        }

        static void LogPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("LogPlain");
        }

        static void LogPlainEvent()
        {
            Console.WriteLine("LogPlain");
        }

        static EventHandler GetEventHandler(object sender, EventArgs e)
        {
            return new EventHandler(LogPlainEvent);
        }

        static void LogKeyEvent(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("LogKey");
        }

        static void LogMouseEvent(object sender, MouseEventArgs e)
        {
            Console.WriteLine("LogMouse");
        }
    }
}
