using System;

namespace ReVolt
{
    class StartUp
    {
        static void Main()
        {
            bool hasWin = false;

            int playerRow = 0;
            int playerCol = 0;

            int size = int.Parse(Console.ReadLine() ?? string.Empty);
            int commandsCount = int.Parse(Console.ReadLine() ?? string.Empty);

            char[][] matrix = new char[size][];
            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                if (currentRow != null)
                {
                    matrix[row] = new char[currentRow.Length];
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] = currentRow[col];
                        if (matrix[row][col] == 'f')
                        {
                            playerRow = row;
                            playerCol = col;
                        }
                    }
                }
            }

            matrix[playerRow][playerCol] = '-';

            for (int index = 0; index < commandsCount; index++)
            {
                string command = Console.ReadLine();
                MovePlayer(matrix, playerRow, playerCol, command);
                if (hasWin)
                {
                    break;
                }
            }


            void MovePlayer(char[][] matrixHere, int x, int y, string move)
            {
                if (move == "down")
                {
                    bool isInside = CheckInField(matrixHere, x + 1, y);
                    playerRow = isInside ? playerRow + 1 : 0;
                    if (matrixHere[playerRow][playerCol] == 'B')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "down");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'T')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "up");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        hasWin = true;
                    }
                }
                else if (move == "up")
                {
                    bool isInside = CheckInField(matrixHere, x - 1, y);
                    playerRow = isInside ? playerRow - 1 : matrixHere.Length - 1;
                    if (matrixHere[playerRow][playerCol] == 'B')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "up");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'T')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "down");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        hasWin = true;
                    }
                }
                else if (move == "left")
                {
                    bool isInside = CheckInField(matrixHere, x, y - 1);
                    playerCol = isInside ? playerCol - 1 : matrixHere.Length - 1;
                    if (matrixHere[playerRow][playerCol] == 'B')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "left");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'T')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "right");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        hasWin = true;
                    }
                }
                else if (move == "right")
                {
                    bool isInside = CheckInField(matrixHere, x, y + 1);
                    playerCol = isInside ? playerCol + 1 : 0;
                    if (matrixHere[playerRow][playerCol] == 'B')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "right");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'T')
                    {
                        MovePlayer(matrix, playerRow, playerCol, "left");
                    }
                    else if (matrixHere[playerRow][playerCol] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        hasWin = true;
                    }
                }
            }

            static bool CheckInField(char[][] matrix, int x, int y)
            {
                return x >= 0 && y >= 0 && x < matrix.Length && y < matrix.Length;
            }

            matrix[playerRow][playerCol] = 'f';

            if (hasWin == false)
            {
                Console.WriteLine("Player lost!");
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
        }
    }
}