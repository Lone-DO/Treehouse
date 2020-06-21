namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        public SniperTower (MapLocation location): base(location)
        {

        }

        protected override double Accuracy { get; } = .90;
        protected override int Range { get; } = 3;
    }
}