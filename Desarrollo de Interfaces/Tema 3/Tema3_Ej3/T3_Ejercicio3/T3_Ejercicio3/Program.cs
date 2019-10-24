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
        public string Title { set; get; }

        public int Year { set; get; }

        enum eGenre
        {
            Arcade,
            Aventuras,
            Shooter,
            Estrategia,
            Pelea
        }


        public Videogames(String titleGame, int yearGame)
        {
            Title = titleGame;
            Year = yearGame;
        }

        public Videogames()
        {
            Title = "";
            Year = 0;
        }

        public override string ToString()
        {
            string datos = ""+Title+" "+Year;
            return datos;
        }
    }

    class VGManagement
    {
        List<Object> GameLibrary = new List<object>();

        public void adder(String titleGame, int yearGame)
        {
            Object game1 = new Videogames(titleGame, yearGame);
            GameLibrary.Add(game1);
        }

        public void shower()
        { 
            foreach (Object obj in GameLibrary)
            {
                Console.WriteLine(obj);
            }
        }
    }

    class Menu
    {
        MyDelegate[] delegates =
        {
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
    }


    class Program
    {
        static void Main(string[] args)
        {
            String[] defaultGamesTitles = {"Monster Hunter World: Iceborne", "Apex Legends", "Horizon Zero Dawn"};
            int[] defaultGamesYears = { 2019, 2018, 2017 };
            int[] defaultGamesGenres = { 1,2,1};
            VGManagement defaultGames = new VGManagement();
            for (int i = 0; i < defaultGamesTitles.Length; i++)
            {
                defaultGames.adder(defaultGamesTitles[i],defaultGamesYears[i]);
            }
            defaultGames.shower();
            Console.ReadKey();
        }
    }
}