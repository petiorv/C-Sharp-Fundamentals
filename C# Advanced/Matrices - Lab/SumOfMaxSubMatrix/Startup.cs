using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SumOfMaxSubMatrix
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] arrSize = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
            int rows = arrSize[0];
            int cols = arrSize[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;
            int r = 0;
            int c = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] n = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = n[col];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        r = i;
                        c = j;
                    }
                }

            }
            Console.WriteLine(133/3);
            Console.WriteLine($"{matrix[r, c]} {matrix[r, c + 1]}");
            Console.WriteLine($"{matrix[r + 1, c]} {matrix[r + 1, c + 1]}");
            Console.WriteLine(sum);
        }
    }
}
