using System;
using System.Text;

namespace Garden
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine()?.Split();
            if (input == null) return;
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);
            var matrix = new int[rows, cols];

            string command;
            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                if (command == null) continue;
                var tokens = command.Split();
                bool success = int.TryParse(tokens[0], out var currentRow);
                if (!success)
                {
                    continue;
                }
                success = int.TryParse(tokens[1], out var currentCol);
                if (!success)
                {
                    continue;
                }
                if (ValidateCoordinate(currentRow, rows) && ValidateCoordinate(currentCol, rows))
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, currentCol]++;
                        matrix[currentRow, i]++;
                    }
                    matrix[currentRow, currentCol]--;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            Console.WriteLine(PrintMatrix(matrix));
        }

        private static bool ValidateCoordinate(int currentRow, int rows)
        {
            return currentRow >= 0 && currentRow < rows;
        }


        private static string PrintMatrix<T>(T[,] matrix)
        {
            var sb = new StringBuilder();
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }

                sb.AppendLine();
            }

            return sb.ToString().Trim();
        }
    }
}
