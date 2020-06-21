using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(10, 20);

            try
            {
                Path path = new Path(
                    new[] {
                    new MapLocation(0, 1, map),
                    new MapLocation(1, 1, map),
                    new MapLocation(2, 1, map),
                    new MapLocation(3, 1, map),
                    new MapLocation(4, 1, map),
                    new MapLocation(5, 1, map),
                    new MapLocation(6, 1, map),
                    new MapLocation(7, 1, map)
                    }
                );

                Invader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new Invader(path),
                };
                Tower[] towers = {
                    new Tower(new MapLocation(1,3, map)),
                    new StrongTower(new MapLocation(2,3, map)),
                    new SniperTower(new MapLocation(3,3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();
                Console.WriteLine($"Player {(playerWon ? "Won" : "lost")}");
            }
            catch (OutOfBoundsException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Unhandled Exception: {err}");
            }

        }
    }
}