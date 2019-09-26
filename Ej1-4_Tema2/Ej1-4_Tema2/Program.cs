using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_4_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Persona
    {
        int age, dniNum;
        String dni, name, surname, dniLet="TRWAGMYFPDXBNJZSQVHLCKE";

        public int Edad
        {
            set
            {
                if (age < 0)
                {
                    this.age = 0;
                }
                else
                {
                    this.age = value;
                }
            }
            get
            {
                return age;
            }
        }
        public String Dni
        {
            set
            {

                if ((dni.Length == 8) && (Int32.TryParse(value, out this.dniNum)))
                {
                    this.dni = value;
                }
                else
                {
                    Console.WriteLine("DNI is invalid. Please, try again.");
                }
            }
            get
            {
                int dniCal = dniNum % 23;
                dni = (dniNum.ToString() + dniLet.ElementAt(dniCal));
                    return dni;
            }
        }
        public String Name { set; get; }
        public String Surname { set; get; }
    }
}
