using System;

namespace TreehousDefense
{
    class Tower
    {
        private const int _power = 1;
        private const int _range = 1;
        private const double _accuracy = .75;
        private static readonly Random _random = new Random();
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            // Add validation so Tower isnt placed on Path
            _location = location;
        }
        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.TakeDamage(_power);
                        Console.WriteLine("Hit Confirmed");
                    }
                    break;
                }
            }
        }
    }
}