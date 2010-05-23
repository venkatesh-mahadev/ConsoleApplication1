using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shapes;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent a = new AutoResetEvent(false);
            a.Set();
            a.WaitOne();
        }
    }
}
