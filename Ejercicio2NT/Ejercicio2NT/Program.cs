using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2NT
{
    class Program
    {


        static void Main(string[] args)
        {
            String phrase1,phrase2;

            Console.WriteLine("Introduce a phrase:");
            phrase1=Console.ReadLine();
            Console.WriteLine("Introduce a second phrase:");
            phrase2 = Console.ReadLine();
            Console.WriteLine("{0} \t {1}\n{0}\n{1}",phrase1,phrase2);
            Console.ReadKey();
        }
    }
}
