using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Matrix_of_Palindromes
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] input = Regex.Split(Console.ReadLine(), " ").Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int rows = input[0];
            int cols = input[1];
            int cnt = 0;

            for (int row = 0; row < rows; row++)
            {
                
                for (int col = 0; col < cols; col++)
                {
                    
                    Console.Write($"{alphabet[row]}{alphabet[cnt+col]}{alphabet[row]} ");
                    
                }
                cnt++;
                Console.WriteLine();
            }
        }
    }
}
