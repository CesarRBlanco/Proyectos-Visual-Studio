using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema1_Ej4
{
    class Program
    {
        static object l = new object();

        public static void horseRun(int horseNumber)
        {
            int correr;
            Random run = new Random();

            for (int j = 0; j < 50; j++)
            {
                correr = run.Next(0, 5);

                lock (l)
                {
                    Console.SetCursorPosition(j, horseNumber);

                    Console.WriteLine("/");

                    Thread.Sleep(50);

                }

                if (j==49)
                {

                }
                //Thread.Sleep(100);
            }
        }

        public static void setRace()
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.SetCursorPosition(i, i2);
                    Console.Write("*");
                }
            }
        }


        static void Main(string[] args)
        {
            setRace();
            Console.ReadKey();
            Thread horse1 = new Thread(() => horseRun(0));
            horse1.Start();
            Thread horse2 = new Thread(() => horseRun(1));
            horse2.Start();
            Console.ReadKey();
            horse1.Abort();
            if (horse1.IsAlive == false)
            {
                Console.WriteLine("acabo 1");
            }

            if (horse2.IsAlive == false)
            {
                Console.WriteLine("acabo 2");
            }


            Console.ReadKey();
        }
    }
}