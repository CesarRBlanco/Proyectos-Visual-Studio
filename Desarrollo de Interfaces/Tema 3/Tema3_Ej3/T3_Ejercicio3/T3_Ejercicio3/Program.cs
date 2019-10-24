using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace T3_Ejercicio3
{
    public delegate void MyDelegate();

    class Videogames : IComparable<Videogames>
    {
        public int GenreIndex { set; get; }

        public string Title { set; get; }

        public int Year { set; get; }

        enum eGenre
        {
            Arcade,
            Aventuras,
            Estrategia,
            Pelea,
            Shooter
        }

        eGenre[] genresArray = {eGenre.Arcade, eGenre.Aventuras, eGenre.Estrategia, eGenre.Pelea, eGenre.Shooter};

        public Videogames(String titleGame, int yearGame, int genreIndex)
        {
            Title = titleGame;
            Year = yearGame;
            GenreIndex = genreIndex;
        }

        public override string ToString()
        {
            string datos =String.Format( "{0} // {1} // {2}",Title,Year,genresArray[GenreIndex]);
            
            return datos;
        }


        public int CompareTo(Videogames other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;

            var yearGameComparison = Year.CompareTo(other.Year);
            if (yearGameComparison != 0) return yearGameComparison;

            var titleComparison = string.Compare(Title, other.Title, StringComparison.Ordinal);
            if (titleComparison != 0) return titleComparison;

            return Year.CompareTo(other.Year);
        }
    }

    class VideoGamesHandler
    {
        static List<Videogames> GameLibrary = new List<Videogames>();
        
        public static void addVideoGame()
        {
            Console.Write("Insert a title: ");
            string   titleGame = Console.ReadLine().Trim();
            Console.Write("Insert a year: ");
            int  yearGame = Int32.Parse(Console.ReadLine().Trim());
            Console.Write("Insert a genre: ");
            int genreIndex = Int32.Parse(Console.ReadLine().Trim());
            Videogames newGame = new Videogames(titleGame, yearGame, genreIndex);
            GameLibrary.Add(newGame);
            GameLibrary.Sort();
        }

        //SObrecarga para los juegos iniciales
        public static void addVideoGame(string titleGame, int yearGame, int genreIndex)
        {
            Videogames newGame = new Videogames(titleGame, yearGame, genreIndex);
            GameLibrary.Add(newGame);
            GameLibrary.Sort();
        }


        public static void showVideoGames()
        {
            foreach (Object obj in GameLibrary)
            {
                Console.WriteLine(obj);
            }
        }
    }



    class Menu : VideoGamesHandler
    {
        static MyDelegate[] delegates = {addVideoGame, showVideoGames};


        public static void menu()
        {
            String titleGame = "";
            int yearGame = 0, genreIndex = 0, opt;
            string[] options =
            {
                "Insert a new game", "Visualize all games", "Delete games", "Visualize one genre", "Modify a game"
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
            String[] defaultGamesTitles = {"Monster Hunter World: Iceborne", "Horizon Zero Dawn", "Apex Legends"};
            int[] defaultGamesYears = {2019, 2017, 2018};
            int[] defaultGamesGenres = {1, 1, 4};

            //----------------------------------------------------------------------------------------------------------
            for (int i = 0; i < defaultGamesTitles.Length; i++)
            {
                VideoGamesHandler.addVideoGame(defaultGamesTitles[i], defaultGamesYears[i], defaultGamesGenres[i]);
            }


            Menu.menu();


            //defaultGames.showVideoGames();
            //Console.ReadKey();
        }
    }
}