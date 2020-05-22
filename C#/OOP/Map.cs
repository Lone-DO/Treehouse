namespace TreehousDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            bool validX = point.X >= 0 && point.X <= Width;
            bool validY = point.Y >= 0 && point.Y <= Height;

            bool inbound = validX && validY;
            bool outbound = !inbound;

            return inbound;
        }
    }

}