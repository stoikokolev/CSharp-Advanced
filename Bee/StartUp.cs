using System;

namespace Bee
{
    class StartUp
    {
        static void Main()
        {
            int pollinatedFlowers = 0;
            var repeats = int.Parse(Console.ReadLine() ?? string.Empty);
            var lost = false;
            var matrix = CreateMatrix(repeats);

            var beeRow = 0;
            var beeCol = 0;

            FindBee(ref beeRow, ref beeCol, matrix);

            while (!lost)
            {
                var command = Console.ReadLine();
                if (command == "up")
                {
                    matrix[beeRow, beeCol] = ".";
                    beeRow -= 1;
                    Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                }
                else if (command == "down")
                {
                    matrix[beeRow, beeCol] = ".";
                    beeRow += 1;
                    Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                }
                else if (command == "left")
                {
                    matrix[beeRow, beeCol] = ".";
                    beeCol -= 1;
                    Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                }
                else if (command == "right")
                {
                    matrix[beeRow, beeCol] = ".";
                    beeCol += 1;
                    Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                }
                else if (command == "End")
                {
                    matrix[beeRow, beeCol] = "B";
                    break;
                }


            }

            if (lost)
            {
                Console.WriteLine("The bee got lost!");
            }

            Console.WriteLine(pollinatedFlowers >= 5
                ? $"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!"
                : $"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void Move(ref int beeRow, ref int beeCol, string[,] matrix, ref int pollinatedFlowers, ref bool lost, string command)
        {
            var border = matrix.GetLength(0);
            if (ValidateIndex(beeRow, border) && ValidateIndex(beeCol, border))
            {
                if (matrix[beeRow, beeCol] == "O")
                {
                    matrix[beeRow, beeCol] = ".";
                    if (command == "up")
                    {
                        beeRow -= 1;
                        Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                    }
                    else if (command == "down")
                    {
                        beeRow += 1;
                        Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                    }
                    else if (command == "left")
                    {
                        beeCol -= 1;
                        Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                    }
                    else if (command == "right")
                    {
                        beeCol += 1;
                        Move(ref beeRow, ref beeCol, matrix, ref pollinatedFlowers, ref lost, command);
                    }
                }
                else if (matrix[beeRow, beeCol] == "f")
                {
                    pollinatedFlowers++;
                    matrix[beeRow, beeCol] = ".";
                }
            }
            else
            {

                lost = true;
            }
        }


        private static bool ValidateIndex(int index, int border)
        {
            return index >= 0 && index < border;
        }

        private static void FindBee(ref int beeRow, ref int beeCol, string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "B")
                    {
                        beeRow = row;
                        beeCol = col;
                        matrix[row, col] = ".";
                        return;
                    }
                }
            }
        }

        private static string[,] CreateMatrix(int n)
        {
            var matrix = new string[n, n];

            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    if (line != null) matrix[row, col] = line[col].ToString();
                }
            }

            return matrix;
        }
    }
}
