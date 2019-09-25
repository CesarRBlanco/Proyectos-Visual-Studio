using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4NT
{
    class Program
    {

        public static void game1()
        {
            String numberDice;
            int cont = 0;
            Console.WriteLine("Introduce a number from 1-6:");
            numberDice = Console.ReadLine();
            Random dice = new Random();
            Console.WriteLine("Dice results:");

            for (int i = 0; i < 10; i++)
            {
                int rNumber = dice.Next(1, 7);
                Console.Write(rNumber + "   ");
                if (rNumber == Int32.Parse(numberDice))
                {
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("El " + numberDice + " ha salido " + cont + " veces.");
            Console.WriteLine();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine();
        }


        public static void game2()
        {
            Random rNumber = new Random();
            int hideNumber = rNumber.Next(1, 101);
            for (int i = 0; i < 5; i++)
            {
                int userNum = Int32.Parse(Console.ReadLine());
                if (userNum < hideNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                if (userNum > hideNumber)
                {
                    Console.WriteLine("Try a lower number.");
                }
                if (userNum == hideNumber)
                {
                    Console.WriteLine("Thats the right number!");
                    return;
                }
            }
            Console.WriteLine("The correct number was: " + hideNumber);
            Console.WriteLine();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine();
        }


        public static void game3()
        {
            Random rNumber = new Random();
            for (int i = 0; i < 15; i++)
            {
                int poolNum = rNumber.Next(1, 101);
                //getPoolResults(poolNum);
            }

        }

        //public static void getPoolResults(int poolNum)
        //{
        //    switch (poolNum)
        //    {
        //        case 15:
        //            break;
        //        case 15 40:
        //            break;
        //        case 40 100:
        //            break;
        //    }
        //}


        static void Main(string[] args)
        {
            String option;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("-------");
                Console.WriteLine("1. Dices");
                Console.WriteLine("2. Guess the number");
                Console.WriteLine("3. Pool");
                Console.WriteLine("4. Play all");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.WriteLine("-------");
                Console.WriteLine("Select an option (1-5):");
                option = Console.ReadLine();
                Console.WriteLine("-------");
                switch (option)
                {
                    case "1":
                        game1();
                        break;

                    case "2":
                        game2();
                        break;

                    case "3":
                        game3();
                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                }
            } while (Int32.Parse(option) != 5);
        }
    }
}
