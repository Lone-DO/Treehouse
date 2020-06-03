namespace Treehouse.MediaLibrary
{
    class Movie : MediaType
    {

        public readonly string Director;


        public Movie(string title, string director) : base(title)
        {
            Director = director;
        }

        public string GetDisplayText()
        {
            string message = $"Movie: {Title} by {Director}";
            if (!string.IsNullOrEmpty(Loanee)) return $"{message} (Currently loaned out to {Loanee})";
            else if (OnLoan) return $"{message} (Currently Loaned out)";
            else return message;
        }

    }
}