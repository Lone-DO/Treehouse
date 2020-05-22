namespace Treehouse.MediaLibrary
{
    class Movie
    {
        public readonly string Title;
        public readonly string Director;
        public string Loanee;
        public bool OnLoan;

        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }

        public string GetDisplayText()
        {
            string message = $"Movie: {Title} by {Director}";
            if (OnLoan) return $"{message} (Currently loaned out to {Loanee})";
            else return message;
        }
        public void Loan(string person)
        {
            Loanee = person;
            OnLoan = true;
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }
}