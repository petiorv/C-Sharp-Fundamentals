using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Startup
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var elementInSequence = new Queue<long>();
            var result = new List<long>();

            elementInSequence.Enqueue(n);
            result.Add(n);
            while (result.Count < 50)
            {
                long currentEl = elementInSequence.Dequeue();
                long firstN = currentEl + 1;
                long secondN = currentEl * 2 + 1;
                long thirdN = currentEl + 2;
                elementInSequence.Enqueue(firstN);
                elementInSequence.Enqueue(secondN);
                elementInSequence.Enqueue(thirdN);

                result.Add(firstN);
                result.Add(secondN);
                result.Add(thirdN);

            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
