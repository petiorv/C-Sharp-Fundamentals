using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Diagonal_Diff
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[,] matrix = new long[n, n];


            for (int row = 0; row < n; row++)
            {
                long[] currentRow = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {

                    matrix[row, col] = currentRow[col];
                }
            }

            long primeDiagonal = 0;
            long secondDiagonal = 0;
            int primeCnt = 0;
            for (int row = 0; row < n; row++)
            {

                primeDiagonal += matrix[row, primeCnt];
                primeCnt++;
            }

            int secondCnt = n-1;
            for (int i = 0; i < n; i++)
            {
                secondDiagonal += matrix[i, secondCnt];
                secondCnt--;
            }
            long diff = Math.Abs(primeDiagonal - secondDiagonal);
            Console.WriteLine(diff);
        }
    }
}
