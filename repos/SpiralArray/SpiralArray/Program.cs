using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 4;
            int[][] matrix = new int[n][];
            matrix[0] = new int[n];
            matrix[1] = new int[n];
            matrix[2] = new int[n];
            matrix[3] = new int[n];



            int count = 1;


            for (int j = 0; j < n; j++)
            {
                matrix[0][j] = count;
                count++;
            }

            for (int j = 1; j < n; j++)
            {
                matrix[j][n - 1] = count;
                count++;
            }

            for (int j = n-2; j >= 0; j--)
            {
                matrix[n-1][j] = count;
                count++;
            }

            for (int j = n - 2; j >= 1; j--)
            {
                matrix[j][0] = count;
                count++;
            }

            for (int j = n - 3; j < 3; j++)
            {
                matrix[n-3][j] = count;
                count++;
            }

            for (int j = n - 2; j > 0; j--)
            {
                matrix[n - 2][j] = count;
                count++;
            }



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
