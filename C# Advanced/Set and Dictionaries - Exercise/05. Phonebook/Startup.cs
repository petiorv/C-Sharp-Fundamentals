namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            

            string comm = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();
            while (!comm.Equals("search"))
            {
                string[] infoArgs = comm.Split('-');
                string name = infoArgs[0];
                string phoneNumber = infoArgs[1];
                
                phonebook[name] = phoneNumber;

                comm = Console.ReadLine();

            }
            var check = Console.ReadLine();
            while (!check.Equals("stop"))
            {
                string name = check;

                if (phonebook.ContainsKey(name))
                    Console.WriteLine($"{name} -> {phonebook[name]}");

                else
                    Console.WriteLine($"Contact {name} does not exist.");

                check = Console.ReadLine();

            }
        }
    }
}
