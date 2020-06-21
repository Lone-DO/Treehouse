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

        public override string ToString() => $"{X},{Y}";
        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;
            Point Obj = obj as Point;

            return this.X == Obj.X && this.Y == Obj.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        public int DistanceTo(int x, int y) => (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - Y, 2));
        public int DistanceTo(Point point) => DistanceTo(point.X, point.Y);
    }
}