using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T1_ej3
{
    class Program
    {
        static readonly private object l = new object();

        public static void addition()
        {
            int threadUp = 0;
            for (threadUp = 0; threadUp <= 1000; threadUp++)
            {
                lock (l)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write(threadUp);


                    //Thread.Sleep(20);
                    if (threadUp == 100)
                    {
                        Console.SetCursorPosition(20, 20);
                        Console.WriteLine("El primero");
                    }
                }
            }
        }

        public static void substraction()
        {
            int threadDown;
            for (threadDown = 0; threadDown >= -1000; threadDown--)
            {
                lock (l)
                {
                    Console.SetCursorPosition(0, 20);
                    Console.Write(threadDown);


                    //Thread.Sleep(20);
                    if (threadDown == -100)
                    {
                        Console.SetCursorPosition(20, 20);
                        Console.WriteLine("El segundo");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Thread one = new Thread(addition);

            one.Start();

            substraction();
            Console.ReadKey();
        }
    }
}