using System;
using System.Text;

namespace MatrixShuffling
{
    class StartUp
    {
        static void Main()
        {
            var dimensions = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (dimensions == null) return;
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);
            var matrix = new string[rows, cols];
            ReadMatrix(rows, cols, matrix);
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == null) continue;
                var arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (arr[0] == "swap")
                {
                    int row1;
                    int row2;
                    int col1;
                    int col2;
                    var success = int.TryParse(arr[1], out var result);
                    if (success)
                    {
                        row1 = result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    var success1 = int.TryParse(arr[2], out var result1);
                    if (success1)
                    {
                        col1 = result1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    var success2 = int.TryParse(arr[3], out var result2);
                    if (success2)
                    {
                        row2 = result2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    var success3 = int.TryParse(arr[4], out var result3);
                    if (success3)
                    {
                        col2 = result3;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }


                    if (row1 < 0 || row1 >= rows || row2 < 0 || row2 >= rows || col1 < 0 || col1 >= cols || col2 < 0 || col2 >= cols)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        var temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;
                        PrintMatrix(matrix);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }


        private static void ReadMatrix(int rows, int cols, string[,] matrix)
        {
            for (var row = 0; row < rows; row++)
            {
                var arr = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (var col = 0; col < cols; col++)
                {
                    if (arr != null) matrix[row, col] = arr[col];
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
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
            Console.Write(sb);
        }

    }
}
