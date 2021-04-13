using System;

namespace FilmDefault
{
    class Program
    {
        enum Genre
        {
            Drama,
            Action,
            SciFi,
            Horror,
            Thriller,
            Fantasy,
            Unknown
        }
        static void Main(string[] args)
        {
            // Film Default
            FilmRuntime("Any Old Flick");
            FilmRuntime("So Long I Forgot The Name", 380);
            FilmRuntime("Return Of The King", 201, Genre.Fantasy);
            FilmRuntime(name: "Matrix", duration: 120, genre: Genre.Action);
        }

        static void FilmRuntime(string name, int duration = 90, Genre genre = Genre.Unknown)
        {
            Console.WriteLine($"{name} ({duration} minuten, {genre})");
        }
    }
}
