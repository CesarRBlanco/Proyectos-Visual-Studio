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
        static bool victoria = false;
        static int winner;
        static Thread[] horses = new Thread[5];

        static void Main(string[] args)
        {
            int select;
                Console.Clear();
                Console.WriteLine("Select a horse from 1-5");
                try
                {
                    select = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    paint();
                    for (int i = 0; i < horses.Length; i++)
                    {
                        horses[i] = new Thread(run);
                        horses[i].Start(i);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    if (select == winner)
                    {
                        Console.WriteLine("You Win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose...");
                    }
                }
                catch (System.FormatException)
                {

                }
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
                Console.WriteLine("|");
            }
        }
        static void run(object y)
        {

            int x = 0;
            int nJump;
            do
            {
                lock (l)
                {
                    Random randJump = new Random();
                    nJump = randJump.Next(0, 10);
                    if (nJump >= 2)
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
                        if (nJump > 2)
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
                            if (!victoria)
                            {
                                Console.SetCursorPosition(55, (int)y);
                                Console.WriteLine("The winner horse is the number {0}.", ((int)y + 1));
                                winner = (int)y + 1;
                                victoria = true;
                            }
                            return;
                        }
                    }
                    //Thread.Sleep(100);
                }

            } while (!victoria);
        }
    }
}

