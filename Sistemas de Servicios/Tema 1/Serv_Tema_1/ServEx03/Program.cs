using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServEx03
{
    class Program
    {
        static readonly private object l = new object();
        static bool closeB, closeA;

        static void Main(string[] args)
        {
            closeB = false;
            closeA = false;
            Thread thread_1 = new Thread(funA);
            Thread thread_2 = new Thread(funB);
            thread_2.Start();
            thread_1.Start();

            Console.ReadKey();
        }


        static void funA()
        {
            int increment;
            for (increment = 0; increment <= 1000; increment++)
            {
                lock (l)
                {
                    if (closeA == true)
                    {

                        return;
                    }
                }
                lock (l)
                {
                    Console.WriteLine(increment);
                    if (increment == 1000)
                    {
                        closeB = true;
                    }
                }
            }
        }

        static void funB()
        {

            int decrement;
            for (decrement = 0; decrement >= -1000; decrement--)
            {
                lock (l)
                {
                    if (closeB == true)
                    {
                        return;
                    }
                }
                lock (l)
                {
                    Console.WriteLine(decrement);
                    if (decrement == -1000)
                    {
                        closeA = true;
                    }
                }
            }
        }
    }
}
