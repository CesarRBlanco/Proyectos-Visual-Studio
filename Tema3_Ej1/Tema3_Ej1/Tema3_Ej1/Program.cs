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
            try
            {
                Console.WriteLine("Introduce an IP for the new element:");
                ip = Console.ReadLine();
                Console.WriteLine("Introduce the GigaBytes of RAM for the new element:");
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
            catch (FormatException e)
            {
                Console.WriteLine("RAM value must be a number.");

            }

            finally
            {
                if (errorKey)
                {
                    Console.WriteLine("IP is not valid.");

                }

            }

        }
        public static void tableShow(Hashtable ipRam)
        {
            foreach (DictionaryEntry de in ipRam)
            {
                Console.WriteLine("Computer {0} has {1} GB of RAM", de.Key, de.Value);
            }

        }
        public static void tableShowOne(Hashtable ipRam, string ipSelect)
        {

         if(ipRam.ContainsKey(ipSelect))
            {
                Console.WriteLine("Computer {0} has {1} GB of RAM", ipSelect, ipRam[ipSelect]);
            }
            else
            {
                Console.WriteLine("The selected IP wasn´t found.");
            }
        }
        public static void menu(int cont, Hashtable ipRam)
        {
            int select;
            string ipSelect;
            try
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Introduce a number please:");
                    select = Int32.Parse(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("");
                            tableModificator(ipRam);
                            break;
                        case 2:
                            Console.WriteLine("");
                            tableShow(ipRam);
                            break;
                        case 3:
                            Console.WriteLine("");
                            ipSelect = Console.ReadLine();
                            tableShowOne(ipRam, ipSelect);
                            break;
                        case 4:

                            break;

                    }
                } while (select != 4);

            }
            catch (FormatException e)
            {
                if (cont < 2)
                {
                    Console.WriteLine("Would you be so kind to introduce a number, please?\n");
                    cont++;
                }
                else
                {
                    Console.WriteLine("Jesus Christ! Write a number you ****** donkey!\n");
                }
                menu(cont, ipRam);
            }
        }
    }
}
