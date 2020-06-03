using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {

                var album = new Album("Yellow Submarine", "The Beatles");
                var book = new Book("Moby-Dick", "Herman Melville");
                book.Loan();
                var movie = new Movie("Lawrence of Arabia", "David Lean");
                // var fakeMovie = new Movie("", "");

                Console.WriteLine(album.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());

                Movie Sonic = new Movie("Sonic Adventures", "Michael Bay");
                Sonic.Loan("Jerry");
                Console.WriteLine(Sonic.GetDisplayText());
                Sonic.Return();
                Console.WriteLine(Sonic.GetDisplayText());

                DetectMediaType(book);
                DetectMediaType(album);
                DetectMediaType(movie);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        static void DetectMediaType(MediaType item)

        {
            string type;
            if (item is Book) type = "book";
            else if (item is Album) type = "album";
            // else if (item is Movie) type = "movie";
            else throw new System.ArgumentException("Exception: Unexpected media subtype encountered.");
            Console.WriteLine($"{item.Title} is an {type}!");
        }
    }
}