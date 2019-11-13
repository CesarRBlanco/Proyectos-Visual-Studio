using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tema3_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Hashtable ipRam = new Hashtable();
            menu(cont, ipRam);
        }

        public static void tableModificator(Hashtable ipRam)
        {
            string ip;
            double ram;
            Boolean errorKey = false;

            Console.Clear();

            try
            {
                Console.Write("Introduce an IP for the new element: ");
                ip = Console.ReadLine();
                Console.Write("Introduce the GigaBytes of RAM for the new element: ");
                ram = Double.Parse(Console.ReadLine());
                string[] ipArray = ip.Split('.');


                // Errores IP
                if (ip == "0.0.0.0")
                {
                    errorKey = true;
                    return;
                }
                if (ipArray.Length > 4)
                {
                    errorKey = true;
                    return;
                }
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        if (Int32.Parse(ipArray[i]) > 255 || Int32.Parse(ipArray[i]) < 0)
                        {
                            errorKey = true;
                            return;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        errorKey = true;
                        return;
                    }

                }


                //Error RAM
                if (ram == 0)
                {
                    Console.WriteLine("The RAM value is incorrect.");
                    return;
                }


                ipRam.Add(ip, ram);

            }
            catch (System.ArgumentException )
            {
                Console.WriteLine("This computer already exists.");
            }
            
            catch (FormatException )
            {
                Console.WriteLine("RAM value must be a number.");

            }

            finally
            {
                if (errorKey)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("IP is not valid.");

                }

            }

        }
        public static void tableShow(Hashtable ipRam)
        {
            Console.Clear();
            if (ipRam.Count == 0)
            {
                Console.WriteLine("No computers have been added to the tale.");
            }

            foreach (DictionaryEntry de in ipRam)
            {
                Console.WriteLine("Computer {0} // {1} GB of RAM", de.Key, de.Value);
            }

        }
        public static void tableShowOne(Hashtable ipRam, string ipSelect)
        {
            Console.Clear();
            if (ipRam.ContainsKey(ipSelect))
            {
                Console.WriteLine("Computer {0} // {1} GB of RAM", ipSelect, ipRam[ipSelect]);
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("The selected IP wasn´t found.");
            }
        }
        public static void menu(int cont, Hashtable ipRam)
        {
            int select;
            string ipSelect;
            string[] menuOptions = {"Introduce a new computer.","Show all computers.","Show one computer."};
            try
            {
                do
                {
                    Console.WriteLine("------------------------------");
                    for (int i = 0; i < menuOptions.Length; i++)
                    {
                        Console.WriteLine("{0}. {1}", i + 1,menuOptions[i]);
                    }
                    Console.WriteLine("0. Exit.");
                    Console.WriteLine("------------------------------");
                    select = Int32.Parse(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            tableModificator(ipRam);
                            break;
                        case 2:
                            tableShow(ipRam);
                            break;
                        case 3:
                            Console.Write("Introduce the IP: ");
                            ipSelect = Console.ReadLine();
                            tableShowOne(ipRam, ipSelect);
                            break;
                        case 4:

                            break;

                    }

                } while (select != 0);

            }
            catch (FormatException e)
            {
                Console.Clear();
                if (cont < 2)
                {
                    Console.Write("Would you be so kind to introduce a number, please?\n");
                    cont++;
                }
                else
                {
                    Console.Write("Jesus Christ! Write a number you ****** donkey!\n");
                }

                menu(cont, ipRam);
            }
        }
    }
}
