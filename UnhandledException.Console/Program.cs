using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhandledException.Core;

namespace UnhandledException.Console
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
#endif
            DoSomething();
        }

        private static void DoSomething()
        {
            throw new NotImplementedException("Exception from DoSomthing()");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var errorMessage = (e.ExceptionObject as Exception).GetInnerExceptionMessage();

            System.Console.WriteLine(errorMessage);
        }
    }
}
