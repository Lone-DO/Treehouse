namespace Treehouse.MediaLibrary
{
    class MediaType
    {

        public string Title { get; private set; }
        public string Loanee { get; private set; } = "";
        public bool OnLoan { get; private set; } = false;

        public MediaType(string title)
        {
            if (string.IsNullOrEmpty(title)) throw new System.ArgumentException("Exception: A media type must have a title.");
            else Title = title;
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

        public string OnLoanText
        {
            get
            {
                if (!string.IsNullOrEmpty(Loanee)) return $"(Currently loaned out to {Loanee})";
                else if (OnLoan) return "(Currently Loaned out)";
                else return "";
            }
        }
    }
}