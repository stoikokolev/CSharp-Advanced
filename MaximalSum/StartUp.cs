using System;
using System.Linq;
using System.Text;

namespace MaximalSum
{
    class StartUp
    {
        static void Main()
        {
            var maxSum = int.MinValue;
            var maxMatrix = new int[3, 3];
            var dimensions = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (dimensions != null)
            {
                var rows = int.Parse(dimensions[0]);
                var cols = int.Parse(dimensions[1]);
                var matrix = new int[rows, cols];
                for (var row = 0; row < rows; row++)
                {
                    var arr = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    for (var col = 0; col < cols; col++)
                    {
                        if (arr != null) matrix[row, col] = arr[col];
                    }
                }

                for (var row = 0; row < rows - 2; row++)
                {

                    for (var col = 0; col < cols - 2; col++)
                    {
                        var sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                  + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                  + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (sum <= maxSum) continue;
                        maxSum = sum;
                        maxMatrix = new[,]
                        {
                            { matrix[row,col], matrix[row, col+1], matrix[row, col+2] },
                            { matrix[row+1, col], matrix[row+1, col+1], matrix[row+1, col+2]},
                            { matrix[row+2, col], matrix[row+2, col+1], matrix[row+2, col+2] }
                        };

                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            var sb = new StringBuilder();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    sb.Append(maxMatrix[row, col] + " ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
