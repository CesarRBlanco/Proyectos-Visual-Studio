using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacionObjetos
{
    interface ICorredor
    {
        void correr();
    }
    class Perro:ICorredor
    {
        public string raza;
        public string nombre;
        private int edad;

        public int Edad
        {
            set
            {
                this.edad = value;
            }
            get
            {
                return edad;
            }
        }

        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void correr()
        {

        }

        public Perro()
        {
            this.setEdad(0);
            this.raza = "";
            this.nombre = "";
        }
        ~Perro()
        {
            Console.WriteLine("Finalizado el perro");
        }
    }
    class Program
    {
        static void Main()
        {
            Perro objPerro;
            objPerro = new Perro();
            objPerro.raza = "Mastín";
            objPerro.nombre = "Laika";
            objPerro.setEdad(5);
            Console.WriteLine(objPerro.getEdad());
            objPerro = null;
            Console.ReadKey();
            GC.Collect();
            Console.ReadLine();
        }
    }
}