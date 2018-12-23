using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form4());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            Thread Test1 = new Thread(() => Application.Run(new Form1()));
            Thread Test2 = new Thread(() => Application.Run(new Form2()));
            Thread Test3 = new Thread(() => Application.Run(new Form3()));
            Thread Test4 = new Thread(() => Application.Run(new Form4()));
            Thread Test5 = new Thread(() => Application.Run(new Form5()));
            Test1.Start();
            Test2.Start();
            Test3.Start();
            Test4.Start();
            Test5.Start();

        }
    }
}
