using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServEx04
{
    class Program
    {
        static readonly private object l = new object();
        static bool jump = true;

        static Thread horse = new Thread(run);
        static Thread horse2 = new Thread(run);
        static Thread horse3 = new Thread(run);
        static Thread horse4 = new Thread(run);
        static Thread horse5 = new Thread(run);

        static void Main(string[] args)
        {
            // Generar un caballo que corra en intervalos aleatorios ininterrumpidos de tiempo
            paint();



            horse.Start(0);
            horse2.Start(1);
            horse3.Start(2);
            horse4.Start(3);
            horse5.Start(4);


            horse.Join();
            horse2.Join();
            horse3.Join();
            horse4.Join();
            horse5.Join();



            Console.ReadKey();

        }


        static void paint()
        {
            for (int j = 0; j < 5; j++)
            {
                Console.SetCursorPosition(0, j);
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("-");
                }
            }
        }

        static void ragnarok()
        { 
           
            

        }


        static void run(object y)
        {
            Random randJump = new Random();
            int x = 0;
            int nJump;
            do
            {
                lock (l)
                {
                    nJump = randJump.Next(0, 10);
                    if (nJump >= 5)
                    {
                        jump = true;
                    }
                    else
                    {
                        jump = false;
                    }
                    while (jump)
                    {
                        nJump = randJump.Next(0, 10);
                        if (nJump > 5)
                        {
                            jump = true;
                        }
                        else
                        {
                            jump = false;
                        }


                        Console.SetCursorPosition(x, (int)y);
                        Thread.Sleep(20);
                        Console.Write("*");
                        x++;
                        if (x >= 50)
                        {
                            Console.SetCursorPosition(10, 10);
                            Console.WriteLine("Victoria" + y);
                            horse.Abort();
                            horse2.Abort();
                            horse3.Abort();
                            horse4.Abort();
                            horse5.Abort();
                            return;
                        }
                    }
                    Thread.Sleep(10);
                }
            } while (x < 50);
        }
    }
}

