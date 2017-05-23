using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_Element
{
    class MaximumElement
    {
        static void Main()
        {
            Stack<long> outputStack = new Stack<long>();
            Stack<long> maxNumbers = new Stack<long>();
            long maxNum = long.MinValue;
            long x = 0;
            int cnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < cnt; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                ushort type = ushort.Parse(input[0]);
                
                if (type == 1)
                {
                    x = long.Parse(input[1]);
                    outputStack.Push(x);
                    if (x >= maxNum)
                    {
                        maxNum = x;
                        maxNumbers.Push(maxNum);
                    }
                }
                else if (type == 2)
                {
                    long topElement = outputStack.Pop();
                    long currentMaxNum = maxNumbers.Peek();
                    if (topElement == currentMaxNum)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            maxNum = maxNumbers.Peek();
                        }
                        else
                        {
                            maxNum = long.MinValue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
