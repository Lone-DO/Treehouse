namespace TreehouseDefense
{
    abstract class Invader : IInvader
    {
        public Invader(Path path) => _path = path;

        private int _pathStep = 0;
        private readonly Path _path;
        protected virtual int StepSize { get; } = 1;
        public virtual int Health { get; protected set; } = 2;
        
        public bool IsNeutralized => Health <= 0;
        
        public void Move() => _pathStep += StepSize;
        public bool HasScored => _pathStep >= _path.Length;
        public bool IsActive => !(IsNeutralized || HasScored);
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public virtual void TakeDamage(int factor) => Health -= factor;
    }
}