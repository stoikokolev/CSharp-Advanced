using System;

namespace TronRacers
{
    class StartUp
    {
        static void Main()
        {
            var matrix = CreateMatrix(int.Parse(Console.ReadLine() ?? string.Empty));
            var firstRow = 0;
            var firstCol = 0;
            var secondRow = 0;
            var secondCol = 0;

            FindPlayers(ref firstRow, ref firstCol, ref secondRow, ref secondCol, matrix);

            while (true)
            {
                bool ended = false;
                var word = Console.ReadLine()?.Split();
                if (word != null)
                {
                    var commandFirst = word[0];
                    var commandSecond = word[1];

                    Move(ref firstRow, ref firstCol, matrix, "s", "f", ref ended, commandFirst);
                    if (ended)
                    {
                        break;
                    }

                    Move(ref secondRow, ref secondCol, matrix, "f", "s", ref ended, commandSecond);
                }

                if (ended)
                {
                    break;
                }
            }

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

        private static void Move(ref int playerRow, ref int playerCol, string[,] matrix, string dieText, string playerText, ref bool ended, string command)
        {
            switch (command)
            {
                case "up":
                    playerRow = ChangeIndex(playerRow - 1, matrix.GetLength(0));
                    MarkRoad(playerRow, playerCol, matrix, dieText, playerText, ref ended);
                    break;
                case "down":
                    playerRow = ChangeIndex(playerRow + 1, matrix.GetLength(0));
                    MarkRoad(playerRow, playerCol, matrix, dieText, playerText, ref ended);
                    break;
                case "left":
                    playerCol = ChangeIndex(playerCol - 1, matrix.GetLength(1));
                    MarkRoad(playerRow, playerCol, matrix, dieText, playerText, ref ended);
                    break;
                case "right":
                    playerCol = ChangeIndex(playerCol + 1, matrix.GetLength(1));
                    MarkRoad(playerRow, playerCol, matrix, dieText, playerText, ref ended);
                    break;
            }
        }

        private static void MarkRoad(in int playerRow, in int playerCol, string[,] matrix, string dieText, string playerText, ref bool ended)
        {
            if (matrix[playerRow, playerCol] == "*")
            {
                matrix[playerRow, playerCol] = playerText;
            }
            else if (matrix[playerRow, playerCol] == dieText)
            {
                matrix[playerRow, playerCol] = "x";
                ended = true;
            }
        }

        private static int ChangeIndex(int playerRowCol, int length)
        {
            if (playerRowCol < 0)
            {
                return length - 1;
            }
            else if (playerRowCol == length)
            {
                return 0;
            }
            else
            {
                return playerRowCol;
            }
        }


        private static void FindPlayers(ref int firstRow, ref int firstCol, ref int secondRow, ref int secondCol,
            string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "f")
                    {
                        firstRow = i;
                        firstCol = j;
                    }
                    else if (matrix[i, j] == "s")
                    {
                        secondRow = i;
                        secondCol = j;
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
