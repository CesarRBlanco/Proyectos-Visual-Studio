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
            int[,] tableNotes = new int[4, 12];
            int note;
            Random notas = new Random();

            for (int i = 0; i < tableNotes.GetLength(0); i++)
            {
                for (int j = 0; j < tableNotes.GetLength(1); j++)
                {
                    note = notas.Next(1, 101);
                    switch (note)
                    {
                        case int n when (n <= 15):
                            note= 2;
                        case int n when ((n > 15) && (n <= 40)):
                            return 'x';
                        case int n when (n > 40):
                            return '1';
                    }
                    return '0';
                }
                tableNotes[i, j] = note;

            }
        }



    }
}
}

