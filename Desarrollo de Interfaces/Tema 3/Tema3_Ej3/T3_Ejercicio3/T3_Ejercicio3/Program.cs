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
            if (genreIndex > 4 || genreIndex < 0)
            {
                Console.WriteLine("Out of bounds");
                return;
            }
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
            int cont = 0;
            foreach (Object obj in GameLibrary)
            {
                cont++;
                Console.WriteLine(cont + ". {0}", obj);
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
            Boolean key = false;
            int moves;
            Console.Write("Insert a range of games: ");
            int range1 = Int32.Parse(Console.ReadLine().Trim());

            Console.Write("Insert a range of games: ");
            int range2 = Int32.Parse(Console.ReadLine().Trim());


            moves = range2 - (range1 - 1);

            int contBack = 0;
            for (int i = 0; i < arrayGames.Length; i++)
            {
                //deleteFailed = true;

                if (i == range1)
                {
                    key = true;
                }
                if (key)
                {


                    GameLibrary.Remove(GameLibrary[range1]);
                    contBack++;
                    if (contBack == moves)
                    {
                        key = false;
                    }
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Delete succesful.");
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

        public static void modifyGame()
        {
            Object[] arrayGames;
            arrayGames = GameLibrary.ToArray();
            arrayGames[2] = "hey";
            for (int i = 0; i < arrayGames.Length; i++)
            {
                Console.WriteLine(arrayGames[i]);
            }
        }


        class Menu : VideoGamesHandler
        {
            static MyDelegate[] delegates = { addVideoGame, deleteGame, showVideoGames, showOneGenre,modifyGame };
            private static int opt;

            public static void menu()
            {
                string[] options =
                {
                "Insert a new game", "Delete games", "Visualize all games", "Visualize one genre", "Modify a game"
                };


                do
                {

                    try
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

                    }
                    catch (System.FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine(
                            "Sorry, characters are not available in the menu.");
                        Console.WriteLine("----------------------------");
                    }
                    catch (System.OverflowException)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine(
                            "Sorry, that number is out of range.");
                        Console.WriteLine("----------------------------");

                    }

                } while (opt != 0);


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
}