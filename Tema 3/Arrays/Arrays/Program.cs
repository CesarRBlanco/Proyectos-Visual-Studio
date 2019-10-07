using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] bi = new int[3, 5];
            for (i = 0; i < bi.GetLength(0); i++) // Cantidad de filas
                for (j = 0; j < bi.GetLength(1); j++) // Cantidad de columnas
                    bi[i, j] = i * (j + 1); // Damos valores iniciales
            for (i = 0; i <= bi.GetUpperBound(0); i++) // Limite superior de filas
                for (j = 0; j <= bi.GetUpperBound(1); j++) // Limite superior de
 Console.WriteLine("Contenido de bi({0},{1})={2}", i, j, bi[i, j]);
            Console.WriteLine("El nº de dimensiones de la matriz bi es {0}", bi.Rank);
            Console.WriteLine("En forma matricial:");
            for (i = 0; i < bi.GetLength(0); i++)
            {
                for (j = 0; j < bi.GetLength(1); j++)
                    Console.Write("{0,3}", bi[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
