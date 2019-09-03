using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AnonymousMethod
{
    /// <summary>
    /// 参数的逆变性
    /// </summary>
    [Description("Contravariance")]
    class Contravariance
    {
        static void LogPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("LogPlain");
        }

        static void Main()
        {
            Button button = new Button();
            button.Text = "Click me";
            //参数的逆变性：传参数时可以用父类
            button.Click += LogPlainEvent;
            button.MouseClick += LogPlainEvent;
            button.KeyPress += LogPlainEvent;

            Form form = new Form();
            form.AutoSize = true;
            form.Controls.Add(button);
            Application.Run(form);
        }
    }
}
