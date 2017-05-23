using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Numbers_with_a_Stack
{
    class ReversiWithStack
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            long[] nums = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            Stack<long> outputStack = new Stack<long>();
            foreach (var num in nums)
            {
                outputStack.Push(num);
            }
            Console.WriteLine(string.Join((" "), outputStack));
            

        }
    }
}
