using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Basic_Queue_Operations
{
    class QueueOperations
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int numsToEnqueue = int.Parse(input[0]);
            int numsToDequeue = int.Parse(input[1]);
            int numToCompare = int.Parse(input[2]);
            Queue<int> outQueue = new Queue<int>();
            var inputQueue = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in inputQueue)
            {
                outQueue.Enqueue(int.Parse(item));
            }

            for (int i = 0; i < numsToDequeue; i++)
            {
                outQueue.Dequeue();
            }
            if (outQueue.Count == 0)
            {
                Console.WriteLine("0");
            }

            else if(outQueue.Peek() == numToCompare)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(outQueue.ToArray().Min());
            }
           

        }
    }
}
