using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Ej1
{
    class Program
    {
        static void f1()
        {
            Console.WriteLine("A");
        }

        static void f2()
        {
            Console.WriteLine("B");
        }

        static void f3()
        {
            Console.WriteLine("C");
        }

        public static void MenuGenerator(string[] vector, Delegate[] delegates)
        {
        }

        static void Main(string[] args)
        {
            //MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
            //    new MyDelegate[] { f1, f2, f3 });
        }
    }
}