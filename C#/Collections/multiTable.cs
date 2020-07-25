using System;
namespace Treehouse.CodeChallenges
{
    public static class MathHelpers
    {
        public static int[][] BuildMultiplicationTable(int maxFactor)
        {
            int[][] table = new int[maxFactor + 1][];
            for (int rowIndex = 0; rowIndex < table.Length; rowIndex++)
            {
                table[rowIndex] = new int[maxFactor + 1];
                for (int colIndex = 0; colIndex < table[rowIndex].Length; colIndex++)
                {
                    if (colIndex == 1)
                    {
                        table[rowIndex][colIndex] = rowIndex;
                    }
                    else
                    {
                        table[rowIndex][colIndex] = rowIndex * colIndex;
                    }
                    Console.WriteLine($"Row {rowIndex}, Col {colIndex}, Value {table[rowIndex][colIndex]}");
                }
            }
            Console.WriteLine(table);
            return table;
        }
    }
}
