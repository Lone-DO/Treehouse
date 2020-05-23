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