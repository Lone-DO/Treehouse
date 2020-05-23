namespace TreehousDefense
{
    class Invader
    {
        private int _pathStep = 0;
        private readonly Path _path;
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move()
        {
            _pathStep++;
        }
    }
}