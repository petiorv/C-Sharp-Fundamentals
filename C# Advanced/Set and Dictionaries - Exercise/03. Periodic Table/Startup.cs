namespace _03.Periodic_Table
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in elements)
                {
                    if (!result.Contains(element))
                    {
                        result.Add(element);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
