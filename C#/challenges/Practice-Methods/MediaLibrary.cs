using System;
namespace Treehouse.MediaLibrary
{
    class MediaLibrary
    {

        public MediaType[] Items { get; private set; }

        public MediaLibrary(MediaType[] items)
        {
            Items = items;
        }

        public MediaType GetItemAt(int index)
        {
            if (index >= this.NumberOfItems)
            {
                System.Console.WriteLine($"Element at {index} doesn't exist");
                return null;
            }
            else return Items[index];
        }
        public int NumberOfItems
        {
            get
            {
                return Items.Length;
            }
        }

        public void DisplayItems()
        {
            for (int index = 0; index < Items.Length; index++)
            {
                if (Items[index] is Book)
                {
                    Book book = (Book)Items[index];
                    Console.WriteLine(book.DisplayText);
                }
                else if (Items[index] is Album)
                {
                    Album album = (Album)Items[index];
                    Console.WriteLine(album.DisplayText);
                }
                else if (Items[index] is Movie)
                {
                    Movie movie = (Movie)Items[index];
                    Console.WriteLine(movie.DisplayText);
                }
                else throw new System.ArgumentException("Exception: Unexpected media subtype encountered.");
            }
        }

        public MediaType FindItem(string criteria)
        {
            foreach (var item in Items)
            {
                if (item.Title.ToLower().Contains(criteria.ToLower()))
                {
                    return item;
                }
            }
            return null;
        }
    }
}