using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();

            var zero = nums.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            var one = nums.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            var two = nums.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            Console.WriteLine(string.Join(" ", zero));
            Console.WriteLine(string.Join(" ", one));
            Console.WriteLine(string.Join(" ", two));
        }
    }
}
