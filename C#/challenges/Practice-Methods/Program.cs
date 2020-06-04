using System.Linq;
using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                MediaType[] Items = {
                    new Album("Yellow Submarine", "The Beatles"),
                    new Album("Black or White", "Michael Jackson"),
                    new Book("Moby-Dick", "Herman Melville"),
                    new Book("Clean Code", "Robert C. Martin"),
                    new Movie("Lawrence of Arabia", "David Lean"),
                    new Movie("Pokemon", "Nintendo")
                };

                MediaLibrary Library = new MediaLibrary(Items);
                Library.GetItemAt(2).Loan("John");
                Library.GetItemAt(4).Loan();

                DetectMediaType(Library.GetItemAt(1));
                DetectMediaType(Library.GetItemAt(3));
                DetectMediaType(Library.GetItemAt(5));
                Display(Library.GetItemAt(0));
                Display(Library.GetItemAt(2));
                Display(Library.GetItemAt(4));
                Display(Library.GetItemAt(6));
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        static void DetectMediaType(MediaType item)

        {
            string type;
            if (item == null) return;
            if (item is Book) type = "book";
            else if (item is Album) type = "album";
            else if (item is Movie) type = "movie";
            else throw new System.ArgumentException("Exception: Unexpected media subtype encountered.");
            Console.WriteLine($"{item.Title} is an {type}!");
        }

        static void Display(MediaType item)
        {
            if (item is Book)
            {
                Book book = (Book)item;
                Console.WriteLine(book.DisplayText);
            }
            else if (item is Album)
            {
                Album album = (Album)item;
                Console.WriteLine(album.DisplayText);
            }
            else if (item is Movie)
            {
                Movie movie = (Movie)item;
                Console.WriteLine(movie.DisplayText);
            }
            else throw new System.ArgumentException("Exception: Unexpected media subtype encountered.");
        }
    }
}