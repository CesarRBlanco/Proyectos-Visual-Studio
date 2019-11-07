using System;
using System.Threading;

namespace Tema1_Ej4
{
    class Program
    {
        static object l = new object();

        public static void setRace()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("-");
                }
            }

            for (int x=0;x<4;x++)
            {
                Console.SetCursorPosition(50,x);

            }
        }

        public static void horseOne()
        {

        }

        static void Main(string[] args)
        {
            setRace();
            Console.ReadKey();
            Thread horse1 = new Thread(horseOne);
            horse1.Start();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}