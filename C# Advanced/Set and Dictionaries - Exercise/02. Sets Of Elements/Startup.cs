namespace _02.Sets_Of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            int[] inputArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int nLength = inputArgs[0];
            int mLength = inputArgs[1];
            int element;

            var nElements = new HashSet<int>();
            var mElements = new HashSet<int>();

            for (int i = 0; i < nLength; i++)
            {
                element = int.Parse(Console.ReadLine());
                nElements.Add(element);
            }

            for (int i = 0; i < mLength; i++)
            {
                element = int.Parse(Console.ReadLine());
                mElements.Add(element);
            }

            var resultElements = nElements.Intersect(mElements);
            Console.WriteLine(string.Join(" ", resultElements));
        }
    }
}
