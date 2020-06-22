using System;

namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Power { get; } = 1;
        protected virtual int Range { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool IsSuccessfulShot() => Random.NextDouble() < Accuracy;

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.TakeDamage(Power);
                        if (invader.IsNeutralized) Console.WriteLine($"Invader neutrulized at, {invader.Location}");
                        Console.WriteLine($"Hit Confirmed");
                    }
                    else Console.WriteLine("Missed");
                    break;
                }
            }
        }
    }
}