using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ej2
{
    class Contest
    {
        private int[,] tableGradesOrigin = new int[4, 12]; // 4 * 12

        string[] contestants = new string[12]
        {
            "Chino Cudeiro", "Abuelo Cudeiro", "Padre Cudeiro", "Madre Cudeiro",
            "Hermano Cudeiro", "Hermana Cudeiro", "Chino Cudeiro 2.0", "Perro Cudeiro",
            "Orieduc Onihc", "Pepe Livingstone", "Paco Peluca", "Juanito Calvicie"
        };

        string[] challenges = new string[4] {"Los rollitos de primavera", "Las zamburguesas", "El laberinto del chino tauro", "El Castillo del general Takeshi"};
        Random randGrade = new Random();
        int grade;

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
            // Table Generator
            for (int i = 0; i < tableGradesOrigin.GetLength(0); i++)
            {
                for (int j = 0; j < tableGradesOrigin.GetLength(1); j++)
                {
                    grade = randGrade.Next(1, 101);
                    tableGradesOrigin[i, j] = gradesCalcutor(grade);
                }
            }

            return tableGradesOrigin;
        }

        public static int gradesCalcutor(int note)
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

        public static void averageGrade(int[,] tableGrades)
        {
            double pocket = 0, average;
            for (int i = 0; i < tableGrades.GetLength(0); i++)
            {
                for (int j = 0; j < tableGrades.GetLength(1); j++)
                {
                    pocket = pocket + tableGrades[i, j];
                }
            }

            average = pocket / tableGrades.Length;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The total average grade is: {0}", Math.Round(average, 2));
            Console.WriteLine("-------------------------------------\n");
        }

        public static void contestantsAverageGrade(int[,] tableGrades, string[] students, string student)
        {
            int selectedStudent = Array.IndexOf(students, student);
            double pocket = 0, average;
            for (int i = 0; i < tableGrades.GetLength(0); i++)
            {
                for (int j = 0; j < tableGrades.GetLength(1); j++)
                {
                    pocket = pocket + tableGrades[i, selectedStudent];
                }
            }

            average = pocket / tableGrades.Length;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The average grade of {1} is: {0}", Math.Round(average, 2), student);
            Console.WriteLine("-------------------------------------\n");
        }

        public static void challengesAverageGrade(int[,] tableGrades, string[] signatures, string asignature)
        {
            int selectedSignature = Array.IndexOf(signatures, asignature);
            double pocket = 0, average;
            for (int i = 0; i < tableGrades.GetLength(0); i++)
            {
                for (int j = 0; j < tableGrades.GetLength(1); j++)
                {
                    pocket = pocket + tableGrades[selectedSignature, j];
                }
            }

            average = pocket / tableGrades.Length;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The average note of {1} is: {0}", Math.Round(average, 2), asignature);
            Console.WriteLine("-------------------------------------\n");
        }

        public static void showContestantsGrade(int[,] tableGrades, string[] students, string student, string[] signatures)
        {
            Console.WriteLine("-------------------------------------");
            int selectedStudent = Array.IndexOf(students, student);
            for (int i = 0; i < tableGrades.GetLength(0); i++)
            {
                Console.Write(signatures[i] + ": " + tableGrades[i, selectedStudent]);
                Console.WriteLine(" ");
            }

            Console.WriteLine("-------------------------------------\n");
        }

        public static void showChallengeGrades(int[,] tableGrades, string[] students, string signature, string[] signatures)
        {
            Console.WriteLine("-------------------------------------");
            int selectedSignature = Array.IndexOf(signatures, signature);
            for (int j = 0; j < tableGrades.GetLength(1); j++)
            {
                Console.Write(students[j] + ": " + tableGrades[selectedSignature, j]);
                Console.WriteLine(" ");
            }

            Console.WriteLine("-------------------------------------\n");
        }

        public static void showMaxAndMin(int[,] tableGrades, string[] students, string student, string[] signatures)
        {
            int max = 0, min = 10;
            int selectedStudent = Array.IndexOf(students, student);
            for (int i = 0; i < tableGrades.GetLength(0); i++)
            {
                if (tableGrades[i, selectedStudent] > max)
                {
                    max = tableGrades[i, selectedStudent];
                }

                if (tableGrades[i, selectedStudent] < min)
                {
                    min = tableGrades[i, selectedStudent];
                }
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Max Note: {0}. Min Note: {1}.", max, min);
            Console.WriteLine("-------------------------------------\n");
        }

        public static void showWinContestants(int[,] tableGrades,string[] students)
        {
            int cont1=0, cont2=0;
            Boolean empty=true;
            Console.WriteLine("-------------------------------------");
            for (int j = 0; j < tableGrades.GetLength(1); j++)
            {
                for (int i = 0; i < tableGrades.GetLength(0); i++)
                {
                    if (cont2 == 4)
                    {
                        cont2 = 0;
                        cont1 = 0;
                    }
                    if (tableGrades[i, j] >= 5)
                    {
                        cont1++;
                        if (cont1 == 4)
                        {
                            Console.Write(students[j]);
                            Console.WriteLine(": Aprobado.");
                            empty=false;
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
        string student, signature;
        int option;

        public void menu(int[,] tableNotes, string[] students, string[] signatures)
        {
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
                Console.Write("Select an option: ");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Contest.averageGrade(tableNotes);
                        break;
                    case 2:
                        student = Console.ReadLine();
                        Contest.contestantsAverageGrade(tableNotes, students, student);
                        break;
                    case 3:
                        signature = Console.ReadLine();
                        Contest.challengesAverageGrade(tableNotes, signatures, signature);
                        break;
                    case 4:
                        student = Console.ReadLine();
                        Contest.showContestantsGrade(tableNotes, students, student, signatures);
                        break;
                    case 5:
                        signature = Console.ReadLine();
                        Contest.showChallengeGrades(tableNotes, students, signature, signatures);
                        break;
                    case 6:
                        student = Console.ReadLine();
                        Contest.showMaxAndMin(tableNotes, students, student, signatures);
                        break;
                    case 7:
                        Contest.showWinContestants(tableNotes, students);
                        break;
                }
            } while (option != 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableNotesCopy;
            Contest classroom = new Contest();
            Menu control = new Menu();
            string[] studentsCopy;
            studentsCopy = classroom.Contestants;
            tableNotesCopy = classroom.tableGenerator();
            // Table Show

            //for (int i = 0; i < tableNotesCopy.GetLength(0); i++)
            //{
            //    Console.WriteLine();

            //    for (int j = 0; j < tableNotesCopy.GetLength(1); j++)
            //    {

            //        Console.Write(tableNotesCopy[i, j]);
            //        Console.Write(" ");
            //    }

            //}


            control.menu(tableNotesCopy, classroom.Contestants, classroom.Challenges);


        }
    }
}