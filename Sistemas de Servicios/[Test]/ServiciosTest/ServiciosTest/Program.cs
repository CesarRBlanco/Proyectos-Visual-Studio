using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p;
            p = Process.Start("Notepad");
            Console.WriteLine("Name: {0}\nPID: {1}\nSubprocesses: {2}\nInit: {3}",
                p.ProcessName, p.Id, p.Threads.Count, p.StartTime);
            p.WaitForExit();
            Console.WriteLine("Aplication finished in date and time {0}", p.ExitTime);
            Console.ReadKey();
        }
    }
}
