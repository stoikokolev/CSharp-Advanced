using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int count = 0;
            var matrix = new char[n, n];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col]=='K')
                    {

                    count += CheckMoves(matrix, row, col);
                    }
                }
            }

            Console.WriteLine(count);
        }

        static int CheckMoves(char[,] matrix, int row, int col)
        {
            int count = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            //right1
            if (col + 1 < cols)
            {
                if (row - 2 >= 0)
                {
                    if (matrix[row - 2, col + 1] == 'K')
                    {
                        matrix[row - 2, col + 1] = '0';
                        count++;
                    }
                }
                if (row + 2 < rows)
                {
                    if (matrix[row + 2, col + 1] == 'K')
                    {
                        matrix[row + 2, col + 1] = '0';
                        count++;
                    }
                }
            }

            //right2
            if (col + 2 < cols)
            {
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col + 2] == 'K')
                    {
                        matrix[row - 1, col + 2] = '0';
                        count++;
                    }
                }
                if (row + 1 < rows)
                {
                    if (matrix[row + 1, col + 2] == 'K')
                    {
                        matrix[row + 1, col + 2] = '0';
                        count++;
                    }
                }
            }


            //down1
            if (row + 1 < rows)
            {
                if (col - 2 >= 0)
                {
                    if (matrix[row + 1, col - 2] == 'K')
                    {
                        matrix[row + 1, col - 2] = '0';
                        count++;
                    }
                }
                if (col + 2 < cols)
                {
                    if (matrix[row + 1, col + 2] == 'K')
                    {
                        matrix[row + 1, col + 2] = '0';
                        count++;
                    }
                }
            }
            //down2
            if (row + 2 < rows)
            {
                if (col - 1 >= 0)
                {
                    if (matrix[row + 2, col - 1] == 'K')
                    {
                        matrix[row + 2, col - 1] = '0';
                        count++;
                    }
                }
                if (col + 1 < cols)
                {
                    if (matrix[row + 2, col + 1] == 'K')
                    {
                        matrix[row + 2, col + 1] = '0';
                        count++;
                    }
                }
            }

            //left1
            if (col - 1 >= 0)
            {
                if (row - 2 >= 0)
                {
                    if (matrix[row - 2, col - 1] == 'K')
                    {
                        matrix[row - 2, col - 1] = '0';
                        count++;
                    }
                }
                if (row + 2 < rows)
                {
                    if (matrix[row + 2, col - 1] == 'K')
                    {
                        matrix[row + 2, col - 1] = '0';
                        count++;
                    }
                }
            }

            //left2
            if (col - 2 >= 0)
            {
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col - 2] == 'K')
                    {
                        matrix[row - 1, col - 2] = '0';
                        count++;
                    }
                }
                if (row + 1 < rows)
                {
                    if (matrix[row + 1, col - 2] == 'K')
                    {
                        matrix[row + 1, col - 2] = '0';
                        count++;
                    }
                }
            }

            //top1
            if (row - 1 >= 0)
            {
                if (col - 2 >= 0)
                {
                    if (matrix[row - 1, col - 2] == 'K')
                    {
                        matrix[row - 1, col - 2] = '0';
                        count++;
                    }
                }
                if (col + 2 < cols)
                {
                    if (matrix[row - 1, col + 2] == 'K')
                    {
                        matrix[row - 1, col + 2] = '0';
                        count++;
                    }
                }
            }

            //top2
            if (row - 2 >= 0)
            {
                if (col - 1 >= 0)
                {
                    if (matrix[row - 2, col - 1] == 'K')
                    {
                        matrix[row - 2, col - 1] = '0';
                        count++;
                    }
                }
                if (col + 1 < cols)
                {
                    if (matrix[row - 2, col + 1] == 'K')
                    {
                        matrix[row - 2, col + 1] = '0';
                        count++;
                    }
                }
            }




            return count;
        }


    }

}
