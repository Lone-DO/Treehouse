using System;
namespace Treehouse.CodeChallenges
{
    public static class MathHelpers
    {
        public static int[,] BuildMultiplicationTable(int maxFactor)
        {
            int[,] table = new int[maxFactor + 1, maxFactor + 1];
            for (int rowIndex = 0; rowIndex < table.GetLength(0); rowIndex++)
            {
                Console.WriteLine($"Row: {rowIndex}");
                for (int colIndex = 0; colIndex < table.GetLength(0); colIndex++)
                {
                    if (colIndex == 1) table[rowIndex, colIndex] = rowIndex;
                    else table[rowIndex, colIndex] = rowIndex * colIndex;
                    Console.WriteLine($"Col: {colIndex}, Value: {table[rowIndex, colIndex]}");
                }
            }
            Console.WriteLine(table);
            return table;
        }
    }
}
