using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServEx01
{
    class Program
    {
        public delegate void MyDelegate();
        public static void MenuGenerator(string[] options, MyDelegate[] functions)
        {
            int selecOpt = 0;
            MyDelegate selecFunct;
            do
            {
                try
                {
                    for (int i = 0; i < options.Length; i++)
                    {
                        Console.WriteLine("{0}. {1}.", i, options[i]);
                    }
                    Console.WriteLine("3. Exit.");
                    selecOpt = Int32.Parse(Console.ReadLine());
                    if (selecOpt == 3)
                    {
                        return;
                    }
                    selecFunct = new MyDelegate(functions[selecOpt]);
                    selecFunct();
                }
                catch (SystemException e)
                {
                    if (e is IndexOutOfRangeException || e is OverflowException)
                    {
                        Console.WriteLine("The selected number is out of bounds.");
                    }
                    if (e is FormatException)
                    {
                        Console.WriteLine("A numeric value is needed.");

                    }
                }
            } while (selecOpt != 3);
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
