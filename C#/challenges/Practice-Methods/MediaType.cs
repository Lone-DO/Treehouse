namespace Treehouse.MediaLibrary
{
    class MediaType
    {
        public string Loanee;
        public bool OnLoan;
        public readonly string Title;

        public MediaType(string title)
        {
            if (!string.IsNullOrEmpty(title)) Title = title;
            else throw new System.ArgumentException("Exception: A media type must have a title.");
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