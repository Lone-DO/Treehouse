using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                Album[] albums = {
                    new Album("Yellow Submarine", "The Beatles"),
                    new Album("Black or White", "Michael Jackson"),
                };
                Book[] books = {
                    new Book("Moby-Dick", "Herman Melville"),
                    new Book("Clean Code", "Robert C. Martin")
                };
                Movie[] movies = {
                    new Movie("Lawrence of Arabia", "David Lean"),
                    new Movie("Pokemon", "Nintendo")
                };

                books[0].Loan();

                Console.WriteLine(albums[0].GetDisplayText());
                Console.WriteLine(books[0].GetDisplayText());
                Console.WriteLine(movies[0].GetDisplayText());

                Movie Sonic = new Movie("Sonic Adventures", "Michael Bay");
                Sonic.Loan("Jerry");
                Console.WriteLine(Sonic.GetDisplayText());
                Sonic.Return();
                Console.WriteLine(Sonic.GetDisplayText());

                DetectMediaType(books[0]);
                DetectMediaType(albums[0]);
                DetectMediaType(movies[0]);
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