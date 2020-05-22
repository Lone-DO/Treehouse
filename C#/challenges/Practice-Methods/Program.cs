using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album = new Album("Yellow Submarine", "The Beatles");
            var book = new Book("Moby-Dick", "Herman Melville");
            var movie = new Movie("Lawrence of Arabia", "David Lean");

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(book.GetDisplayText());
            Console.WriteLine(movie.GetDisplayText());

            Movie Sonic = new Movie("Sonic Adventures", "Michael Bay");
            Sonic.Loan("Jerry");
            Console.WriteLine(Sonic.GetDisplayText());
            Sonic.Return();
            Console.WriteLine(Sonic.GetDisplayText());
            Sonic.Loan();
            Console.WriteLine(Sonic.GetDisplayText());
        }
    }
}