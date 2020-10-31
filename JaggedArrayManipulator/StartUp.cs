using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class StartUp
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine() ?? string.Empty);
            var matrix = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                if (input != null)
                    matrix[row] = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
                        .ToArray();
            }

            for (var row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (var i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] *= 2;
                    }

                    for (var i = 0; i < matrix[row + 1].Length; i++)
                    {
                        matrix[row + 1][i] *= 2;
                    }

                }
                else
                {
                    for (var i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] /= 2;
                    }

                    for (var i = 0; i < matrix[row + 1].Length; i++)
                    {
                        matrix[row + 1][i] /= 2;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == null) continue;
                var arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (arr[0] != "Add")
                {
                    if (arr[0] != "Subtract") continue;

                    if (!int.TryParse(arr[1], out int row) || !int.TryParse(arr[2], out int col)) continue;
                    double value = double.Parse(arr[3]);

                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }

                }
                else
                {
                    if (!int.TryParse(arr[1], out int row) || !int.TryParse(arr[2], out int col)) continue;

                    double value = double.Parse(arr[3]);

                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
            }



            foreach (var row in matrix)
            {
                Console.Write(string.Join(' ', row));
                Console.WriteLine();
            }
        }
    }
}
