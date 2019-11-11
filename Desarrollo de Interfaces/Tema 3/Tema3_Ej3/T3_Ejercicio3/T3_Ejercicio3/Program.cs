using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace T3_Ejercicio3
{
    public delegate void MyDelegate();

    class Videogames : IComparable<Videogames>
    {
        public int GenreIndex { set; get; }

        public String OriginalTitle { set; get; }

        public String _title;

        public String Title
        {
            set
            {
                if (value.Length >= 18)
                {
                    value = value.Remove(15);
                    value = value.Insert(15, "...");
                    _title = value;
                }
                else
                {
                    int finalS;
                    int blancs = 0;
                    blancs = 18 - value.Length;
                    for (int i = 0; i < blancs; i++)
                    {
                        finalS = value.Length;
                        value = value.Insert(finalS, " ");
                    }
                    _title = value;
                }
            }
            get => _title;
        }

        public int Year { set; get; }

        enum eGenre
        {
            Arcade,
            Aventuras,
            Estrategia,
            Pelea,
            Shooter
        }

        eGenre[] genresArray = { eGenre.Arcade, eGenre.Aventuras, eGenre.Estrategia, eGenre.Pelea, eGenre.Shooter };

        public Videogames(String titleGame, int yearGame, int genreIndex)
        {
            Title = titleGame;
            OriginalTitle = titleGame;
            Year = yearGame;
            GenreIndex = genreIndex;
        }

        public override string ToString()
        {
            string datos = String.Format("{0} // {1} // {2}", Title, Year, genresArray[GenreIndex]);

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

        //@TODO AÑADIR TRYCATCH

        public static void addVideoGame()
        {
            Console.Write("Insert a title: ");
            string titleGame = Console.ReadLine().Trim();
            Console.Write("Insert a year: ");
            int yearGame = Int32.Parse(Console.ReadLine().Trim());
            Console.Write("[0. Arcade, 1. Aventuras, 2. Estrategia, 3. Pelea, 4. Shooter]\n");
            Console.Write("Insert a genre: ");
            int genreIndex = Int32.Parse(Console.ReadLine().Trim());
            Videogames newGame = new Videogames(titleGame, yearGame, genreIndex);
            GameLibrary.Add(newGame);
            GameLibrary.Sort();
        }

        //Sobrecarga para los juegos iniciales
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

        /*TODO
         *Se eliminan varios a la vez usando rango de posiciones (Desde X hasta Z) 
         */
        public static void deleteGame() 
        {
            Boolean deleteFailed = false;
            Object[] arrayGames;
            string titleComparator;
            arrayGames = GameLibrary.ToArray();


            Console.Write("Insert a title: ");
            string titleGame = Console.ReadLine().Trim().ToLower();
            for (int i = 0; i < arrayGames.Length; i++)
            {
                deleteFailed = true;
                titleComparator = GameLibrary[i].GetType().GetProperty("OriginalTitle").GetValue(GameLibrary[i]).ToString().Trim().ToLower();
                if (titleComparator.Equals(titleGame))
                {

                    GameLibrary.Remove(GameLibrary[i]);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Delete succesful.");

                    return;
                }

            }

            if (deleteFailed)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sorry, the requested game was not found.");
            }

        }

        public static void showOneGenre()
        {
            Object[] arrayGames;
            string genreComparator;
            arrayGames = GameLibrary.ToArray();


            Console.Write("Insert a genre number: ");
            string genreGame = Console.ReadLine().Trim().ToLower();
            for (int i = 0; i < arrayGames.Length; i++)
            {
                genreComparator = GameLibrary[i].GetType().GetProperty("GenreIndex").GetValue(GameLibrary[i]).ToString().Trim().ToLower();
                if (genreComparator.Equals(genreGame))
                {

                    Console.WriteLine(GameLibrary[i].GetType().GetProperty("OriginalTitle").GetValue(GameLibrary[i]).ToString());
                    
            
                }

            }
        }


        class Menu : VideoGamesHandler
        {
            static MyDelegate[] delegates = { addVideoGame, showVideoGames, deleteGame, showOneGenre};


            public static void menu()
            {
                string[] options =
                {
                "Insert a new game", "Visualize all games", "Delete games", "Visualize one genre", "Modify a game"
            };
                try
                {
                    int opt;
                    do
                    {
                        Console.WriteLine("----------------------------");
                        for (int i = 0; i < options.Length; i++)
                        {
                            Console.WriteLine("{0}. {1}.", i + 1, options[i]);
                        }

                        Console.WriteLine("0. Exit.");
                        Console.WriteLine("----------------------------");
                        opt = Int32.Parse(Console.ReadLine().Trim());

                        if (opt <= 0 || opt >= options.Length + 1)
                        {
                            Console.Clear();
                            Console.WriteLine("----------------------------");
                            Console.WriteLine(
                                "Sorry, {0} is not any of the numbers in the menu.", opt);
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("----------------------------");
                            delegates[opt - 1]();
                            Console.WriteLine("----------------------------");
                        }

                    } while (opt != 0);
                }
                catch (System.FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------");
                    Console.WriteLine(
                        "Sorry, characters are not available in the menu.");
                    Console.WriteLine("----------------------------");
                    menu();
                }
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                String[] defaultGamesTitles = { "Monster Hunter World: Iceborne", "Horizon Zero Dawn", "Apex Legends" };
                int[] defaultGamesYears = { 2019, 2017, 2018 };
                int[] defaultGamesGenres = { 1, 1, 4 };

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
}