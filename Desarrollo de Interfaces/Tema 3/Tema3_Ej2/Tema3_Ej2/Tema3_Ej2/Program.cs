using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ej2
{
    class Contest
    {
        private int[,] tableResultsOrigin = new int[4, 12]; // 4 * 12

        public string[] contestants = new string[12]
        {
            "Chino Cudeiro", "Abuelo Cudeiro", "Padre Cudeiro", "Madre Cudeiro",
            "Hermano Cudeiro", "Hermana Cudeiro", "Chino Cudeiro 2.0", "Perro Cudeiro",
            "Orieduc Onihc", "Pepe Livingstone", "Paco Peluca", "Juanito Calvicie"
        };

        public string[] challenges = new string[4]
        {
            "Los rollitos de primavera", "Las zamburguesas", "El laberinto del chino tauro",
            "El Castillo del general Takeshi"
        };


        public string[] Contestants
        {
            get => contestants;
            set => contestants = value;
        }

        public string[] Challenges
        {
            get => challenges;
            set => challenges = value;
        }

        public int[,] tableGenerator()
        {
            Random randResult = new Random();
            int result;
            // Table Generator
            for (int i = 0; i < tableResultsOrigin.GetLength(0); i++)
            {
                for (int j = 0; j < tableResultsOrigin.GetLength(1); j++)
                {
                    result = randResult.Next(1, 101);
                    tableResultsOrigin[i, j] = resultsCalcutor(result);
                }
            }

            return tableResultsOrigin;
        }

        public static int resultsCalcutor(int result)
        {
            switch (result)
            {
                case int n when (n <= 5): // 5%
                    return 0;
                case int n when (n > 5 && n <= 10): // 5%
                    return 1;
                case int n when (n > 10 && n <= 15): // 5%
                    return 2;
                case int n when (n > 15 && n <= 25): // 10%
                    return 3;
                case int n when (n > 25 && n <= 40): // 15%
                    return 4;
                case int n when (n > 40 && n <= 55): // 15%
                    return 5;
                case int n when (n > 55 && n <= 70): // 15%
                    return 6;
                case int n when (n > 70 && n <= 80): // 10%
                    return 7;
                case int n when (n > 80 && n <= 90): // 10%
                    return 8;
                case int n when (n > 90 && n <= 95): // 5%
                    return 9;
                case int n when (n > 95): // 5%
                    return 10;
            }

            return '0';
        }

        public static void averageResult(int[,] tableResults)
        {
            double pocket = 0, average;
            for (int i = 0; i < tableResults.GetLength(0); i++)
            {
                for (int j = 0; j < tableResults.GetLength(1); j++)
                {
                    pocket = pocket + tableResults[i, j];
                }
            }

            average = pocket / tableResults.Length;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The total average result is: {0}", Math.Round(average, 2));
            Console.WriteLine("-------------------------------------\n");
        }


        public static void contestantsAverageResult(int[,] tableResults, string[] contestants, int contestant)
        {
            double pocket = 0, average;
                for (int i = 0; i < tableResults.GetLength(0); i++)
                {
                    for (int j = 0; j < tableResults.GetLength(1); j++)
                    {
                        pocket = pocket + tableResults[i, contestant - 1];
                    }
                }
            average = pocket / tableResults.Length;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("The average result of {0} is: {1}", contestants[contestant - 1], Math.Round(average, 2));
                Console.WriteLine("-------------------------------------\n");
         }


        public static void challengesAverageResult(int[,] tableResults, string[] challenges, int challenge)
        {
            double pocket = 0, average;
          
                for (int i = 0; i < tableResults.GetLength(0); i++)
                {
                    for (int j = 0; j < tableResults.GetLength(1); j++)
                    {
                        pocket = pocket + tableResults[challenge - 1, j];
                    }
                }

                average = pocket / tableResults.Length;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("The average result of {0} is: {1}", challenges[challenge - 1], Math.Round(average, 2));
                Console.WriteLine("-------------------------------------\n");
            
  
        }

        public static void showContestantsResult(int[,] tableResults, int contestant,
            string[] challenges)
        {
          
                Console.WriteLine("-------------------------------------");
                for (int i = 0; i < tableResults.GetLength(0); i++)
                {
                    Console.Write(i + 1 + ". " + challenges[i] + " : " + tableResults[i, contestant - 1]);
                    Console.WriteLine(" ");
                }

                Console.WriteLine("-------------------------------------\n");
          
        }

        public static void showChallengeResults(int[,] tableResults, string[] contestans, int challenge)
        {
           
                Console.WriteLine("-------------------------------------");
                for (int j = 0; j < tableResults.GetLength(1); j++)
                {
                    Console.Write(j + 1 + ". " + contestans[j] + ": " + tableResults[challenge - 1, j]);
                    Console.WriteLine(" ");
                }

                Console.WriteLine("-------------------------------------\n");
        
        }

        public static void showMaxAndMin(int[,] tableResults, int contestant, string[] challenges)
        {
            int max = 0, min = 10;
       
                for (int i = 0; i < tableResults.GetLength(0); i++)
                {
                    if (tableResults[i, contestant - 1] > max)
                    {
                        max = tableResults[i, contestant - 1];
                    }

                    if (tableResults[i, contestant - 1] < min)
                    {
                        min = tableResults[i, contestant - 1];
                    }
                }

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Max Result: {0}. \nMin Result: {1}.", max, min);
                Console.WriteLine("-------------------------------------\n");
            
          
        }

        public static void showWinContestants(int[,] tableResults, Contest classrom)
        {
            int cont1 = 0, cont2 = 0;
            Boolean empty = true;
            Console.WriteLine("-------------------------------------");
        
                for (int j = 0; j < tableResults.GetLength(1); j++)
                {
                    for (int i = 0; i < tableResults.GetLength(0); i++)
                    {
                        if (cont2 == 4)
                        {
                            cont2 = 0;
                            cont1 = 0;
                        }

                        if (tableResults[i, j] >= 5)
                        {
                            cont1++;
                            if (cont1 == 4)
                            {
                                Console.Write(j + 1 + ". " + classrom.contestants[j]);
                                Console.WriteLine(": Has win Humor Amarillo.");
                                showContestantsResult(tableResults, j + 1, classrom.challenges);
                                empty = false;
                            }
                        }

                        cont2++;
                    }
                }
         
            if (empty == true)
            {
                Console.WriteLine("Nobody has won Humor Amarillo");
            }
        }
    }

    class Menu
    {
        int contestant, option, challenge;

        public void menu(int[,] tableResults, Contest classrom)
        {
            try
            {
                do
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("1. Total average result.");
                    Console.WriteLine("2. Average of one contestant.");
                    Console.WriteLine("3. Average of one challenge.");
                    Console.WriteLine("4. Show all results of one contestant.");
                    Console.WriteLine("5. Show all results of one challenge.");
                    Console.WriteLine("6. Max. and min. result of one contestant.");
                    Console.WriteLine("7. Show only results above 5.");
                    Console.WriteLine("0. Exit.");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Select an option: ");
                    option = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    if (option > 7 || option < 0)
                    {
                        Program.showTable(tableResults, classrom);
                        Console.WriteLine("---------");
                        Console.WriteLine(
                            "Sorry, {0} is not an option in this menu.", option);
                        Console.WriteLine("---------");
                    }

                    switch (option)
                    {
                        case 1:
                            Contest.averageResult(tableResults);
                            break;
                        case 2:
                            Program.showTable(tableResults, classrom);
                            Console.Write("Select the contestant number: ");
                            contestant = Int32.Parse(Console.ReadLine());
                            Contest.contestantsAverageResult(tableResults, classrom.contestants, contestant);
                            break;
                        case 3:
                            Program.showTable(tableResults, classrom);
                            Console.Write("Select the challenge number: ");
                            challenge = Int32.Parse(Console.ReadLine());
                            Contest.challengesAverageResult(tableResults, classrom.challenges, challenge);
                            break;
                        case 4:
                            Program.showTable(tableResults, classrom);
                            Console.Write("Select the contestant number: ");
                            contestant = Int32.Parse(Console.ReadLine());
                            Contest.showContestantsResult(tableResults, contestant,
                                classrom.challenges);
                            break;
                        case 5:
                            Program.showTable(tableResults, classrom);
                            Console.Write("Select the challenge number: ");
                            challenge = Int32.Parse(Console.ReadLine());
                            Contest.showChallengeResults(tableResults, classrom.contestants, challenge);
                            break;
                        case 6:
                            Program.showTable(tableResults, classrom);
                            Console.Write("Select the contestant number: ");
                            contestant = Int32.Parse(Console.ReadLine());
                            Contest.showMaxAndMin(tableResults, contestant, classrom.challenges);
                            break;
                        case 7:
                            Contest.showWinContestants(tableResults, classrom);
                            break;
                    }
                } while (option != 0);

            }

            catch (System.FormatException e)
            {
                Console.Clear();
                Console.WriteLine("---------");
                Console.WriteLine(
                    "Sorry, characters are not available in the menu.");
                Console.WriteLine("---------");
                menu(tableResults, classrom);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine("---------");
                Console.WriteLine(
                    "Sorry, the number selected is not a contestant/challenge.");
                Console.WriteLine("---------");
                menu(tableResults, classrom);
            }
        }
        class Program
        {
            public static void showTable(int[,] tableResultsCopy, Contest classroom)
            {
                Console.Write("         Contestants:");
                for (int z = 0; z < 12; z++)
                {
                    Console.Write("{0,5}.", z + 1);
                }

                Console.WriteLine("");
                Console.Write(
                    "---------------------------------------------------------------------------------------------");
                for (int i = 0; i < tableResultsCopy.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.Write(i + 1 + ". " + classroom.Challenges[i].Remove(15).Insert(15, "..."));
                    for (int j = 0; j < tableResultsCopy.GetLength(1); j++)
                    {
                        Console.Write("{0,5}", tableResultsCopy[i, j]);
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine(
                    "---------------------------------------------------------------------------------------------");
            }


            static void Main(string[] args)
            {
                int[,] tableResultsCopy;
                Contest classroom = new Contest();
                tableResultsCopy = classroom.tableGenerator();
                Menu control = new Menu();
                string[] contestantsCopy;
                contestantsCopy = classroom.Contestants;
                tableResultsCopy = classroom.tableGenerator();
                showTable(tableResultsCopy, classroom);
                control.menu(tableResultsCopy, classroom);
            }
        }
    }
}
