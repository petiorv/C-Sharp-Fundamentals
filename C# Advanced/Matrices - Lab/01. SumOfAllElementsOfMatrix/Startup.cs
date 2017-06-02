using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.SumOfAllElementsOfMatrix
{
    class Startup
    {
        static void Main(string[] args)
        {
            string[] mSize = Console.ReadLine().Split(',');
            int cols = int.Parse(mSize[1]);
            int rows = int.Parse(mSize[0]);
            long sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] arrRow = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    sum += arrRow[col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
