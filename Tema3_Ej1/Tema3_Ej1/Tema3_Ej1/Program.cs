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
            menu(cont,ipRam);
        }



        public static void tableModificator(Hashtable ipRam)
        {
            string ip;
            double ram;
            try
            {
                Console.WriteLine("Introduce an IP for the new element:");
                ip = Console.ReadLine();
                Console.WriteLine("Introduce the GigaBytes of RAM for the new element:");
                ram = Double.Parse(Console.ReadLine());
                if (ip == "0" && ram == 0)
                {
                    return;
                }
                ipRam.Add(ip, ram);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Well, it looks like the Ram value is not valid. What unfortunate.\n");
                tableModificator(ipRam);
            }
        }

        public static void tableShow(Hashtable ipRam)
        {
            foreach (DictionaryEntry de in ipRam)
            {
                Console.WriteLine("Computer {0} has {1} GB of RAM", de.Key, de.Value);
            }
        }

        public static void tableShowOne(Hashtable ipRam,string ipSelect)
        {
            Console.WriteLine("Computer {0} has {1} GB of RAM",ipSelect, ipRam[ipSelect]);
        }

        public static void menu(int cont, Hashtable ipRam)
        {
            int select;
            string ipSelect;
            try
            {
                do
                {
                    Console.WriteLine("Introduce a number please:");
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
                            ipSelect = Console.ReadLine();
                            tableShowOne(ipRam,ipSelect);
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
                menu(cont,ipRam);
            }
        }
    }
}
