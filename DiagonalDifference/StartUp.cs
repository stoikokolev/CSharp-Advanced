using System;
using System.Linq;

namespace DiagonalDifference
{
    class StartUp
    {
        static void Main()
        {
            var sum1 = 0;
            var sum2 = 0;
            var size = int.Parse(Console.ReadLine() ?? string.Empty);
            var matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                var arr = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
                
                for (var col = 0; col < size; col++)
                {
                    if (arr != null) matrix[row, col] = arr[col];
                }
            }

            for (var row = 0; row < size; row++)
            {
                sum1 += matrix[row, row];
                sum2 += matrix[row, size - row - 1];
            }

            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
