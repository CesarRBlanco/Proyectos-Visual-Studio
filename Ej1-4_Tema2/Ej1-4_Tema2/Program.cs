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
        String dni, name, surname, dniLet = "TRWAGMYFPDXBNJZSQVHLCKE";

        public int Age
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
        public void showInfo()
        {
            Console.WriteLine("Name: {0},Surname: {1},Age: {2},DNI: {4}.", Name, Surname, Age, Dni);
        }
        public void modInfo()
        {
            Console.Write("Insert name: ");
            this.Name = Console.ReadLine();
            Console.Write("Insert surname: ");
            this.Surname = Console.ReadLine();
            Console.Write("Insert age: ");
            this.Age = Int32.Parse(Console.ReadLine());
            Console.Write("Insert Dni: ");
            this.Dni = Console.ReadLine();

        }
        public Persona(String name, string surname, string dni, int age)
        {
            this.name = name;
            this.surname = surname;
            this.dni = dni;
            this.age = age;
        }
        public Persona()
            : this("", "", "", 0)
        {
        }
        //abstract double hacienda()
        //{
        //    return;
        //}

    }

    class Empleado : Persona
    {
        double salary, irpf;
        string phone;

        public double Salary { set; get; }
        private double Irpf
        {
            set
            {
                if (salary <= 600)
                {
                    irpf = 7;
                }
                if ((salary > 600) || (salary <= 3000))
                {
                    irpf = 15;
                }
                if (salary > 3000)
                {
                    irpf = 20;
                }
            }
            get
            {
                return irpf;
            }
        }
        public string Phone
        {
            set
            {
                this.Phone = phone;
            }
            get
            {
                return ("+34" + phone);
            }
        }
        public void showEInfo()
        {
            Console.WriteLine("Name: {0}, Surname: {1}, Age: {2}, Dni: {3}, Phone: {4}, Salary: {5}, IRPF: {6}",this.Name,this.Surname,this.Age,this.Dni,Phone,Salary,Irpf);
        }
        public void showEInfo(int select)
        {
            String selectData="Invalid selection";
            switch (select)
            {
                case 0:
                    selectData = Name;
                    break;
                case 1:
                    selectData = Surname;
                    break;
                case 2:
                    selectData = Age.ToString();
                    break;
                case 3:
                    selectData = Dni;
                    break;
                case 4:
                    selectData = Phone;
                    break;
                case 5:
                    selectData = Salary.ToString();
                    break;
                case 6:
                    selectData = Irpf.ToString();
                    break;
            }
            Console.WriteLine(selectData);

        }
        //abstract double hacienda()
        //{
        //    return Irpf * Salary / 100;
        //}
        public Empleado(String name, string surname, string dni, int age,string phone,double salary,double irpf) 
        {
            
        }
    }
}
