using System;
namespace Treehouse.MediaLibrary
{
    class MediaLibrary
    {

        private MediaType[] _items;

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }

        public MediaType GetItemAt(int index)
        {
            if (index >= _items.Length)
            {
                System.Console.WriteLine($"Element at {index} doesn't exist");
                return null;
            }
            else return _items[index];
        }
    }
}