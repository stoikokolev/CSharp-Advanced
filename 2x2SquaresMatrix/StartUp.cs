using System;
using System.Linq;

namespace _2x2SquaresMatrix
{
    class StartUp
    {
        static void Main()
        {
            int count = 0;
            var dimensions = Console.ReadLine()?.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            if (dimensions != null)
            {
                int rows = int.Parse(dimensions[0]);
                int cols = int.Parse(dimensions[1]);
                var matrix = new char[rows, cols];
                for (int row = 0; row < rows; row++)
                {
                    var arr = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                    
                    for (int col = 0; col < cols; col++)
                    {
                        if (arr != null) matrix[row, col] = arr[col];
                    }
                }

                for (var row = 0; row < rows - 1; row++)
                {

                    for (var col = 0; col < cols - 1; col++)
                    {
                        if (matrix[row, col] == matrix[row + 1, col]
                            && matrix[row, col] == matrix[row, col + 1]
                            && matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            count++;
                        }

                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
