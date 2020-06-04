namespace Treehouse.MediaLibrary
{
    class Movie : MediaType
    {

        public string Director { get; private set; }


        public Movie(string title, string director) : base(title)
        {
            Director = director;
        }

        // public string DisplayText
        // {
        //     get
        //     {
        //         string message = $"Movie: {Title} by {Director}";
        //         if (!string.IsNullOrEmpty(Loanee)) return $"{message} (Currently loaned out to {Loanee})";
        //         else if (OnLoan) return $"{message} (Currently Loaned out)";
        //         else return message;
        //     }
        // }

        public string DisplayText => $"Movie: {Title} by {Director} {OnLoanText}";


    }
}