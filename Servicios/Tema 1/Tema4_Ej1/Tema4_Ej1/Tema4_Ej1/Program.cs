using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Ejercicio1
{
    class Program
    {
        public delegate void MyDelegate();

        public static void MenuGenerator(string[] options, MyDelegate[] delegates)
        {
            int opt;
            try
            {
                do
                {
                    for (int i = 0; i < options.Length; i++)
                    {
                        Console.WriteLine(i + 1 + "." +
                                          " {0}", options[i]);
                    }
                    Console.WriteLine("4. Exit");
                    opt = Int32.Parse(Console.ReadLine());
                    if (opt == 4)
                    {
                        return;
                    }
                    if (opt <= 0 || opt >= options.Length+1)
                    {
                        Console.WriteLine(
                            "Sorry, but that, maybe, perhaps, u know, i don't know, that's not any of the numbers in the menu.");
                    }
                    else
                    {
                        Console.WriteLine("---------");
                        delegates[opt - 1]();
                        Console.WriteLine("---------");
                    }
                } while (opt != 4);
            }
            catch (FormatException e)
            {
                Console.WriteLine(
                    "Wow, stop right there fella! That's not a number, you need some lessons of grammar or something?");
                MenuGenerator(options, delegates);
            }
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
            MenuGenerator(new string[] {"Op1", "Op2", "Op3"},
                new MyDelegate[] {f1, f2, f3});
            //Console.ReadKey();
        }
    }
}