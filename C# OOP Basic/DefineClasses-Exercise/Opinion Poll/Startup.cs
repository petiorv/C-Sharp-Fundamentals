namespace Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);
                var person = new Person(personName, personAge);
                family.AddMember(person);
            }

            List<Person> resultList = family.GetOlderThan30();

            foreach (var person in resultList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
