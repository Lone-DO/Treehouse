using System;

namespace TreehousDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(10, 20);

            Point point = new Point(4, 2);
            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);
            point = new Point(11, 19);
            isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);
        }
    }
}