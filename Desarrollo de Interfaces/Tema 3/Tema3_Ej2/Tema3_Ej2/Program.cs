﻿using System;

namespace Tema3_Ej2
{
    class Classrom
    {
        // DECLARACION DE VARIABLES
        private int[,] notes = new int[4, 12];
        private string[] students ={"GenericBoy1","GenericBoy2","GenericBoy3","GenericBoy4","GenericBoy5","GenericBoy6",
                        "GenericGirl1","GenericGirl2","GenericGirl3","GenericGirl4","GenericGirl5","GenericGirl6"};
        private enum eSubjects
        {
            Programing,
            Databases,
            Web,
            Android
        }
        private int pocket = 0;
        private string[] selectedNotes;

        // Indexacion de la tabla
        public int this[int index1, int index2]
        {
            set
            {
                notes[index1, index2] = value;
            }
            get
            {
                return notes[index1, index2];
            }
        }


        // CREACION DE LA TABLA
        // Rellenado de la tabla a traves de la ponderación de las notas
        public void tableGenerator()
        {
            Random rand = new Random();
            int randSelection;
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    randSelection = rand.Next(1, 101);
                    notes[i, j] = noteCalculation(randSelection);
                }
            }
        }

        // Ponderacion de notas a un numero del 1-10 sin decimales
        public int noteCalculation(int randSelection)
        {
            switch (randSelection)
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


        // METODOS DE LA TABLA
        // Media total de notas
        public int averageNoteAll()
        {
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    pocket = pocket + notes[i, j];
                }
            }
            return pocket = pocket / notes.Length;
        }

        // Media de un único alumno
        public int averageNoteStudent(int selectedStudent)
        {
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                pocket = pocket + notes[i, selectedStudent];
            }
            return pocket = pocket / notes.GetLength(0);
        }

        // Media de una única asignatura
        public int averageNoteSubject(int selectSubject)
        {
            for (int i = 0; i < notes.GetLength(1); i++)
            {
                pocket = pocket + notes[selectSubject, i];
            }
            return pocket = pocket / notes.GetLength(1);
        }

        // Visualizar notas de un alumno
        public string[] showStudentNotes(int selectedStudent)
        {
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                selectedNotes[i] = notes[i, selectedStudent].ToString();
            }
            return selectedNotes;
        }

        // Visualizar notas de una asignatura
        public string[] showSubjectNotes(int selectedSubject)
        {
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                selectedNotes[i] = notes[selectedSubject, i].ToString();
            }
            return selectedNotes;
        }

        // Visualizar nota máxima y minima
        public ref studentMaxAndMin(int selectedStudent,ref int min,ref int max)
        {



            return min + max;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}