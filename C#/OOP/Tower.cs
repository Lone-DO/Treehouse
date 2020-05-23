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
            int index = 0;
            while (index < invaders.Length)
            {
                Invader invader = invaders[index];
                // Do stuff to invader

                index++;
            }
        }
    }
}