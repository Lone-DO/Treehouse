namespace TreehouseDefense
{
    class Invader
    {
        private int _pathStep = 0;
        protected virtual int StepSize { get;} =1;
        public virtual int Health { get; protected set; } = 2;
        private readonly Path _path;
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public Invader(Path path) => _path = path;
        public bool HasScored => _pathStep >= _path.Length;
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);
        public void Move() => _pathStep += StepSize;

        public virtual void TakeDamage(int factor) => Health -= factor;
    }
}