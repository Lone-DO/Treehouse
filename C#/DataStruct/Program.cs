﻿using System;
using System.Collections.Generic;
using System.Linq;
using static GenericsDemo.EnumerableCompositor;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            var set1 = new HashSet<int> { 3, 6, 9, 12, 15 };
            var array1 = new[] { 4, 8, 12, 16, 20 };
            var numOdd = EC(list1, list2, set1, array1).Count(x => IsOdd(x));
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
