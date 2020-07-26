using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            var set1 = new HashSet<int> { 3, 6, 9, 12, 15 };
            var array1 = new[] { 4, 8, 12, 16, 20 };

            int numOdd = 0;
        }
    }
}