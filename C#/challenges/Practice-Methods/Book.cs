namespace Treehouse.MediaLibrary
{
    class Book : MediaType
    {
        public string Author { get; set; }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public string DisplayText => $"Book: {Title} by {Author} {OnLoanText}";
    }
}