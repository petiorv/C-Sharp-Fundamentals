namespace _07.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cnt = 0;
            string name = "";
            string mail = "";
            var userDictionary = new Dictionary<string, string>();
            while (!input.ToLower().Equals("stop"))
            {
                if (cnt % 2 == 0)
                {
                    name = input;
                }
                else
                {
                    mail = input;
                    string[] email = mail.Split('.');
                    string domain = email[(email.Length) - 1];
                    if(!domain.Equals("us") && !domain.Equals("uk"))
                    {
                        userDictionary[name] = mail;
                    }
                }
                cnt++;
                input = Console.ReadLine();
            }
            foreach (var user in userDictionary)
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }
        }
    }
}
