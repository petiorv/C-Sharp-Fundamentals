namespace _01.Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();
            for (int i = 0; i < cnt; i++)
            {
                string name = Console.ReadLine();
                if (!usernames.Contains(name))
                {
                    usernames.Add(name);
                }
            }
            foreach (var name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
