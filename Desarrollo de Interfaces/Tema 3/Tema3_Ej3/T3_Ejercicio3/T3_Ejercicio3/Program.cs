using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T3_Ejercicio3
{
    public delegate void MyDelegate();

    class Videogames
    {
        private string title;
        private int year;
        List<Object> gamesCollection = new List<Object>();

        enum eGenre
        {
            Arcade,
            Videoaventura,
            Shootemup,
            Estrategia,
            Deportivo
        }

        private string Title { set; get; }
        int Year { set; get; }

        public Videogames(string title, int year)
        {
            this.Title = title;
            this.Year = year;
        }

        public Videogames()
        {
            title = "";
            year = 0;
        }

        public void gameInserter(string newTitle, int newYear)
        {
            Videogames newGame = new Videogames(newTitle, newYear);
            gamesCollection.Add(newGame);
        }

        public void showGames()
        {
            foreach (int num in gamesCollection)
                Console.Write(num);
        }
    }

    class Menu
    {
        MyDelegate[] delegates =
        {
            insertGames, deleteGames, visualizeGames, visualizeOneGenre, modifyGames, deleteGames
        };


        public void menu()
        {
            int opt;
            string[] options =
            {
                "Insert a new game", "Delete games", "Visualize all games", "Visualize one genre", "Modify a game"
            };

            do
            {
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine("{0}. {1}.", i + 1, options[i]);
                }
                Console.WriteLine("0. Exit.");
                opt = Int32.Parse(Console.ReadLine());

                if (opt <= 0 || opt >= options.Length + 1)
                {
                    Console.WriteLine("---------");
                    Console.WriteLine(
                        "Sorry, but that, maybe, perhaps, u know, i don't know, that's not any of the numbers in the menu.");
                    Console.WriteLine("---------");
                }
                else
                {
                    Console.WriteLine("---------");
                    delegates[opt - 1]();
                    Console.WriteLine("---------");
                }
            } while (opt != 0);
        }

        public static void insertGames()
        {

            Videogames steam = new Videogames();
            string newTitle;
            int newYear;
            Console.WriteLine("-Title-");
            newTitle = Console.ReadLine();
            Console.WriteLine("-Year-");
            newYear = Int32.Parse(Console.ReadLine());
            steam.gameInserter(newTitle, newYear);
        }

        public static void deleteGames()
        {
            Console.WriteLine("-delete-");

        }

        public static void visualizeGames()
        {
            Console.WriteLine("-visualizeAll-");
            Videogames steam = new Videogames();
            steam.showGames();
        }

        public static void visualizeOneGenre()
        {
            Console.WriteLine("-visualizeGenre-");
            Videogames casa = new Videogames();
        }

        public static void modifyGames()
        {
            Console.WriteLine("-Modify-");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu mn = new Menu();
            mn.menu();
            //Console.ReadKey();
        }
    }
}