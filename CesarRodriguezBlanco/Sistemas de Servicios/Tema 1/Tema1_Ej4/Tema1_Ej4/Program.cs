using System;
using System.Threading;

namespace Tema1_Ej4
{
    class Program
    {
        static object l = new object();

        static void horseOne()
        {
            lock (l) 
                Monitor.Wait(l);
            for (int i = 1; i <= 50; i++)
            {
                lock (l)
                {
                    Console.SetCursorPosition(1, 20);
                    Console.Write("{0,4}", i);
                    Thread.Sleep(50);
                }
            }
            for (int x = 0; x < 4; x++)
            {
                Console.SetCursorPosition(50, x);

            }
        }

        static void horseTwo()
        {
      
            for (int i = 1; i <= 50; i++)
            {
                lock (l)
                {
                    Console.SetCursorPosition(1, 20);
                    Console.Write("{0,4}", i);
                    Thread.Sleep(50);
                    lock (l)
                    {
                        Monitor.Pulse(l);
                    }
                }
            }
            //if (i == 15) // Warn thread writeDown to begin
                lock (l)
                {
                    Monitor.Pulse(l);
                }
        
            for (int x = 0; x < 4; x++)
            {
                Console.SetCursorPosition(0, x);
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(horseOne);
            Thread thread2 = new Thread(horseTwo);
            thread2.Start();
            thread.Start();

            //for (int i = 1; i <= 30; i++)
            //{
            //    lock (l)
            //    {
            //        Console.SetCursorPosition(1, 1);
            //        Console.Write("{0,4}", i);
            //    }
            //    Thread.Sleep(50);
            //    if (i == 15) // Warn thread writeDown to begin
            //        lock (l)
            //        {
            //            Monitor.Pulse(l);
            //        }
            //}
            Console.ReadKey();
        }
    }
}
