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
            if (!string.IsNullOrEmpty(Loanee)) return $"{message} (Currently loaned out to {Loanee})";
            else if (OnLoan) return $"{message} (Currently Loaned out)";
            else return message;
        }
        public void Loan(string person)
        {
            Loanee = person;
            Loan();
        }

        public void Loan()
        {
            OnLoan = true;
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }
}