using System;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int DistanceTo(int x, int y) => (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - Y, 2));
        public int DistanceTo(Point point) => DistanceTo(point.X, point.Y);
    }
}