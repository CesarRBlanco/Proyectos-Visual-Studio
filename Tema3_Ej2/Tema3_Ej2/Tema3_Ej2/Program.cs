using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableNotes = new int[4, 4]; // 4 * 12
            int note;
            Random notas = new Random();

            // Table Generator
            for (int i = 0; i < tableNotes.GetLength(0); i++)
            {
                for (int j = 0; j < tableNotes.GetLength(1); j++)
                {

                    note = notas.Next(1, 101);
                    tableNotes[i, j] = noteCalculator(note);
                }
            }

            // Table Show
            //for (int i = 0; i < tableNotes.GetLength(0); i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < tableNotes.GetLength(1); j++)
            //    {
            //        Console.Write(tableNotes[i, j]);
            //        Console.Write(" ");
            //    }
            //}


            menu(tableNotes);
            Console.ReadKey();
        }


        public static void menu(int[,] tableNotes)
        {
            int option;
            do
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1. Total average note.");
                Console.WriteLine("2. Average of one student.");
                Console.WriteLine("3. Average of one signature.");
                Console.WriteLine("4. Show all notes of one student.");
                Console.WriteLine("5. Show all notes of one signature.");
                Console.WriteLine("6. Max. and min. note of one student.");
                Console.WriteLine("7. Show only <5 notes.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Select an option:");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        averageNote(tableNotes);
                        break;
                    case 2:
                        studentAverageNote(tableNotes);
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 0:

                        break;
                }
            } while (option != 0);
        }

        public static int noteCalculator(int note)
        {
            switch (note)
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

        public static void averageNote(int[,] tableNotes)
        {
            double pocket = 0, average;
            for (int i = 0; i < tableNotes.GetLength(0); i++)
            {
                for (int j = 0; j < tableNotes.GetLength(1); j++)
                {
                    pocket = pocket + tableNotes[i, j];
                }
            }
            average = pocket / tableNotes.Length;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The total average note is: {0}", average);
            Console.WriteLine("-------------------------------------\n");
        }

        public static void studentAverageNote(int[,] tableNotes)
        {
            int studentNumber;

            studentNumber = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < tableNotes.GetLength(0); i++)
            {
                for (int j = 0; j < tableNotes.GetLength(1); j++)
                {
                    Console.WriteLine(tableNotes[i, studentNumber]);
                }
            }
        }
    }

}

