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
            for (int i = 0; i < tableNotes.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < tableNotes.GetLength(1); j++)
                {
                    Console.Write(tableNotes[i, j]);
                    Console.Write(" ");
                }
            }


            menu();
            averageNote(tableNotes);
            Console.ReadKey();
        }


        public static void menu()
        {
            //Conso
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
            Console.WriteLine(average);
        }


    }

}

