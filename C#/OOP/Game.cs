namespace TreehousDefense
{
    class Game
    {
        static void Main()
        {
            Map map = new Map();
            map.Width = 10;
            map.Height = 20;

            int area = map.Width * map.Height;
        }
    }
}