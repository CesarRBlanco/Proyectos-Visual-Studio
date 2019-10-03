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
            Employee empo1 = new Employee("Juan", "Algo", "77015143", 35, "651533815", 1500);
            
            empo1.showInfo();
            Console.ReadKey();

        }
    }

    abstract class Person
    {
        int age, dniNum;
        String dni="77015143", dniLet = "TRWAGMYFPDXBNJZSQVHLCKE";

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
                try { 
                    if (value.Length == 8)
                    {
                 
                        int dniCal = Int32.Parse(dni) % 23;
                        dni = dni + dniLet.ElementAt(dniCal);
                        this.Dni = dni;
                }
                }
                catch (Exception x)
                {
                    dni = value;
                }


            }
                get
            {
    
                    return dni;
                }
            }
        public String Name { set; get; }
        public String Surname { set; get; }
        public virtual void showInfo()
        {
            Console.WriteLine("Name: {0},\nSurname: {1},\nAge: {2},\nDNI: {3}.", Name, Surname, Age, Dni);
        }
        public virtual void modInfo()
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
        public Person(string name, string surname, string dni, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Dni = dni;
            this.Age = age;
        }
        public Person()
            : this("", "", "", 0)
        {
        }
        public abstract double hacienda();
    }

    class Employee : Person
    {
        double salary, irpf;
        string phone;

        public double Salary
        {
            set
            {
                if (salary <= 600)
                {
                    irpf = 7;
                }
                if (salary > 600 && salary <= 3000)
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
                return salary;
            }
        }
        private double Irpf
        {
            set { }
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
                return "+34" + phone;
            }
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Phone: {0}, Salary: {1}, IRPF: {2}", Phone, Salary, Irpf);

        }
        public void showInfo(int select)
        {
            String selectData = "Invalid selection";
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
        public override double hacienda()
        {
            return Irpf * Salary / 100;
        }
        public Employee(String name, string surname, string dni, int age, string phone, double salary) : base(name, surname, dni, age)
        {
            this.salary = salary;
            this.phone = phone;
        }
        public Employee() : this("", "", "", 0, "", 0)
        {

        }
    }

    interface iPastaGansa
    {
        void ganarPasta(double benefits);
    }

    //class Directive : Person, iPastaGansa
    //{
    //    String department;
    //    int numEmployes;
    //    double benfits;
    //    public string Department { set; get; }
    //    public int NumEmployes
    //    {
    //        set
    //        {
    //            if (NumEmployes <= 10)
    //            {
    //                Benefits = 2;
    //            }
    //            if (NumEmployes > 10 && NumEmployes<=50)
    //            {
    //                Benefits = 3.5;
    //            }
    //            if (NumEmployes > 50)
    //            {
    //                Benefits = 4;
    //            }

    //        }
    //        get            {
    //            return NumEmployes;
    //        }
    //    }
    //    public double Benefits { set; get; }
    //    public override void showInfo()
    //    {
    //        base.showInfo();
    //        Console.WriteLine("Department: {0}, Benfits: {1}, Number of Employees per Department: {2}",Department,Benefits,NumEmployes);
    //    }
    //    public override void modInfo()
    //    {
    //        base.modInfo();
    //        Console.Write("Insert department: ");
    //        this.Department = Console.ReadLine();
    //        Console.Write("Insert Number of Employees per department: ");
    //        this.Age = Int32.Parse(Console.ReadLine());

    //    }
    //    public override double hacienda()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ganarPasta(double casa)
    //    {

    //    }


    //}




}
