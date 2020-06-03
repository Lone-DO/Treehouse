namespace Treehouse.MediaLibrary
{
    class Book : MediaType
    {
        public readonly string Author;

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public string GetDisplayText()
        {
            string message = $"Book: {Title} by {Author}";
            if (!string.IsNullOrEmpty(Loanee)) return $"{message} (Currently loaned out to {Loanee})";
            else if (OnLoan) return $"{message} (Currently Loaned out)";
            else return message;
        }
    }
}