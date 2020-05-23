namespace TreehousDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            // Add validation so Tower isnt placed on Path
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {

            for (int i = 0; i < invaders.Length; i++)
            {
                // Do stuff to invader
                Invader invader = invaders[i];
            }
        }
    }
}