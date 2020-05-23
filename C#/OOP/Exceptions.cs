namespace TreehousDefense
{
    class TreehousDefenseException : System.Exception
    {
        public TreehousDefenseException()
        {

        }
        public TreehousDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TreehousDefenseException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}