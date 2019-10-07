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
            int cont = 0;
            Random rNumber = new Random();
            for (int i = 0; i < 14; i++)
            {
                cont++;
                int poolNum = rNumber.Next(1, 101);
                Console.Write(getPoolResults(poolNum));
                if (cont == 5)
                {
                    Console.WriteLine();
                    cont = 0;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine();
        }
        public static char getPoolResults(int poolNum)
        {

            switch (poolNum)
            {
                case int n when (n <= 15):
                    return '2';
                case int n when ((n > 15) && (n <= 40)):
                    return 'x';
                case int n when (n > 40):
                    return '1';
            }
            return '0';
        }


        static void Main(string[] args)
        {
            bool allG;
            String option;
            do
            {
                allG = false;
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
                        if (allG)
                        {
                            goto case "2";
                        }
                        break;

                    case "2":
                        game2();
                        if (allG)
                        {
                            goto case "3";
                        }
                        break;

                    case "3":
                        game3();
                        break;

                    case "4":
                        allG = true;
                        goto case "1";
                        break;

                    case "5":

                        break;

                }
            } while (Int32.Parse(option) != 5);
        }
    }
}
