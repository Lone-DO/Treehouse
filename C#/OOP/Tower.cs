namespace TreehousDefense
{
    class Tower
    {
        private const int _power = 1;
        private const int _range = 1;
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            // Add validation so Tower isnt placed on Path
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.TakeDamage(_power);
                    break;
                }
            }
        }
    }
}