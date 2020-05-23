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
                MapLocation[] mapLocation = {
                    new MapLocation(0, 1, map),
                    new MapLocation(1, 1, map),
                    new MapLocation(2, 1, map),
                    new MapLocation(3, 1, map),
                    new MapLocation(4, 1, map),
                    new MapLocation(5, 1, map),
                    new MapLocation(6, 1, map),
                    new MapLocation(7, 1, map)
                };

            }
            catch (OutOfBoundsException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (TreehousDefenseException)
            {
                Console.WriteLine("Unhandled Exception");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }

        }
    }
}