using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class StartUp
    {
        static void Main()
        {
            var arr = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (arr == null) return;

            var rows = arr[0];
            var cols = arr[1];
            var word = Console.ReadLine();
            var input = new Queue<char>(word ?? string.Empty);
            var matrix = new char[rows, cols];

            for (var row = 0; row < rows; row++)
            {
                if (row % 2 != 0)
                {
                    if (row % 2 != 1) continue;

                    for (var col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = input.Peek();
                        input.Enqueue(input.Dequeue());
                    }
                }
                else
                {
                    for (var col = 0; col < cols; col++)
                    {
                        matrix[row, col] = input.Peek();
                        input.Enqueue(input.Dequeue());
                    }

                }
            }

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
