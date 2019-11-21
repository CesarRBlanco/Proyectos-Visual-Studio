using System;

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
        public int[,] tableGenerator()
        {
            Random rand = new Random();
            int randSelection;
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    randSelection = rand.Next(30, 101);
                    notes[i, j] = noteCalculation(randSelection);
                }
            }
            return notes;
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
            return   pocket / notes.Length;
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
        public void studentMaxAndMin(int selectedStudent, ref int min, ref int max)
        {
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                if (notes[i, selectedStudent] > max)
                {
                    max = notes[i, selectedStudent];
                }
                if (notes[i, selectedStudent] < min)
                {
                    min = notes[i, selectedStudent];
                }

            }
        }

        // Tabla de aprobados
        public void approvedStudents(ref string[] approvedStudents, ref string[] approvedNotes)
        {
            int contApproves = 0, contNotes = 0, contArrayStudents = 0, contArrayNotes = 0, lastApprovedIndex = 0;
            Boolean empty = true, notesKey = false;

            for (int j = 0; j < notes.GetLength(1); j++)
            {

                for (int i = 0; i < notes.GetLength(0); i++)
                {
                    // Entra una vez contadas cuatro notas
                    if (contNotes == 4)
                    {
                        contNotes = 0;

                        // Marca a 0 el indice de aprobados para evitar que detecte dos alumnos diferentes como uno mismo aprobado
                        contApproves = 0;

                        // Entra si la llave a sido puesta a false, para reiniciar el array de notas al ultimo punto de guardado +1 (menos si es 0)
                        if (!notesKey)
                        {
                            if (lastApprovedIndex == 0)
                            {
                                contArrayNotes = lastApprovedIndex;
                            }
                            else
                            {
                                contArrayNotes = lastApprovedIndex + 1;
                            }
                        }
                    }

                    approvedNotes[contArrayNotes] = notes[i, j].ToString();

                    // Entra si la nota es superior a 5
                    if (notes[i, j] >= 5)
                    {
                        contApproves++;

                        //Si hay 4 aprobados seguidos entra, los guarda en un array y guarda la ultima posicion en la que se guardó una nota aprovada
                        if (contApproves == 4)
                        {
                            approvedStudents[contArrayStudents] = students[j];
                            contArrayStudents++;
                            lastApprovedIndex = contArrayNotes;
                            empty = false;
                            notesKey = true;
                        }
                    }
                    else
                    {
                        notesKey = false;
                    }
                    contArrayNotes++;
                    contNotes++;
                }


            }
            if (empty == true)
            {
                approvedNotes = null;
                approvedStudents = null;
            }
        }

    }


    class UserInterface
    {
        Classrom newClassrom = new Classrom();
        int[,] tableCopy;
        int selectedStudent, selectedSubject, min, max, option;
        string[] approvedStudents, approvedNotes;

        // Creacion de la tabla y copia a una variable trabajable
        public void tableMaker()
        {
            tableCopy = newClassrom.tableGenerator();
        }


        // Averiguar tamaño
        public void showTable()
        {

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(newClassrom[i, j]);
                }
            }
        }


        public void menu()
        {

            switch (option)
            {
                case 1:
                    newClassrom.averageNoteAll();
                    break;

                case 2:
                    newClassrom.averageNoteStudent(selectedStudent);
                    break;

                case 3:
                    newClassrom.averageNoteSubject(selectedSubject);
                    break;

                case 4:

                    newClassrom.showStudentNotes(selectedStudent);
                    break;

                case 5:
                    newClassrom.showSubjectNotes(selectedSubject);
                    break;

                case 6:
                    newClassrom.studentMaxAndMin(selectedStudent, ref min, ref max);
                    break;

                case 7:
                    newClassrom.approvedStudents(ref approvedStudents, ref approvedNotes);
                    break;

                case 8:
                    showTable();
                    break;
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[,] copytable;
         
            UserInterface n2 = new UserInterface();
            //n2.tableMaker();
            //n2.showTable();
            Classrom c = new Classrom();

        }
    }
}
