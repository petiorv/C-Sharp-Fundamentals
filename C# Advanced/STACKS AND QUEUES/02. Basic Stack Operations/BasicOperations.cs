using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Basic_Stack_Operations
{
    public class BasicOperations
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int[] cmd = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int cnt = cmd[0];
            Stack<int> stackNums = new Stack<int>();
            int[] nums;
            var inputNums = Console.ReadLine();
            nums = inputNums.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var item in nums)
            {
                stackNums.Push(item);
            }
            if (nums.Length == cnt)
            {
                for (int i = 0; i < cmd[1]; i++)
                {
                    stackNums.Pop();
                }
                if (stackNums.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    if (stackNums.Contains(cmd[2]))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine(stackNums.ToArray().Min());

                    }
                }

            }


        }
    }
}
