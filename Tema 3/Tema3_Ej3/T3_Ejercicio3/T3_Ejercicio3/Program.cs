using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Ejercicio3
{
    public delegate void MyDelegate();

    class Videogames
    {
        string title;
        int year;

        enum eGenre
        {
            Arcade,
            Videoaventura,
            Shootemup,
            Estrategia,
            Deportivo
        }
    }

    class Menu
    {
        MyDelegate[] delegates =
        {
        };

        public void menu(string[] options)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("{0}. {1}.", i + 1, options[i]);
            }
            Console.WriteLine("0. Exit.");

        }

        public void insertGames()
        {
        }

        public void deleteGames()
        {
        }

        public void visualizeGames()
        {
        }

        public void visualizeOneGenre()
        {
        }

        public void modifyGames()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] options =
            {
                "Insert a new game", "Delete games", "Visualize all games", "Visualize one genre", "Modify a game"
            };
            Menu mn = new Menu();
            mn.menu(options);
            Console.ReadKey();
        }
    }
}