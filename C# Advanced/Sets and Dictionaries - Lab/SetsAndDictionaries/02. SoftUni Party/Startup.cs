namespace _02.SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            bool over = true;
            string input = Console.ReadLine();
            var guests = new SortedSet<string>();
            while (over)
            {
                guests.Add(input);
                if (input=="PARTY")
                {
                    while (true)
                    {
                        guests.Remove(input);
                        if (input=="END")
                        {
                            over = false;
                            break;
                        }
                        input = Console.ReadLine();
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(guests.Count);
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}



