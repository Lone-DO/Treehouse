using System;

namespace TreehousDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(10, 20);



            try
            {
                MapLocation mapLocation = new MapLocation(11, 20, map);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}