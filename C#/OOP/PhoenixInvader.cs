using System.IO;

namespace TreehouseDefense
{
    class PhoenixInvader : IInvader
    {
        BasicInvader _incarnation1;
        StrongInvader _incarnation2;
        public PhoenixInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);
        }

        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;
        public virtual int Health => _incarnation1.IsNeutralized? _incarnation2.Health: _incarnation1.Health;
        public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;
        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;
        public bool IsActive => !(IsNeutralized || HasScored);
        
        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }
        public virtual void TakeDamage(int factor)
        {
            if (!_incarnation1.IsNeutralized) _incarnation1.TakeDamage(factor);
            else _incarnation2.TakeDamage(factor);
        }
    }
}