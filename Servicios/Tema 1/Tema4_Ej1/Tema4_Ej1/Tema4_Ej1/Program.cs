using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Ej1
{
    class Program
    {
        public delegate void MyDelegate();
        public static void MenuGenerator(string[] options,MyDelegate[] delegates)
        {
            Console.WriteLine("1. {0}",options[0]);
            Console.WriteLine("2. {0}", options[1]);
            Console.WriteLine("3. {0}", options[2]);
            Console.WriteLine("4. Exit");
        }
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
        static void Main(string[] args)
        {

            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
                new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();
        
        }
    }
}