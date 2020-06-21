namespace TreehouseDefense
{
    class StrongTower : Tower
    {
        public StrongTower (MapLocation location) : base(location)
        {

        }

        protected override int Power { get; } = 3;
        protected override double Accuracy { get; } = .6;
    }
}