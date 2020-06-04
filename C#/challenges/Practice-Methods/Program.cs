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
                Library.DisplayItems();

                DetectMediaType(Library.FindItem("Pokem"));
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        static void DetectMediaType(MediaType item)

        {
            string type;
            if (item == null)
            {
                Console.WriteLine("Item Not Found");
                return;
            }
            if (item is Book) type = "book";
            else if (item is Album) type = "album";
            else if (item is Movie) type = "movie";
            else throw new System.ArgumentException("Exception: Unexpected media subtype encountered.");
            Console.WriteLine($"{item.Title} is an {type}!");
        }
    }
}