namespace OldestFamilyMember
{
    using System;

    public class Startup
    {
        static void Main(string[] args)
        {
            var family = new Family();
            var nubmerOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < nubmerOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var personName = personInfo[0];
                var personAge = int.Parse(personInfo[1]);

                var person = new Person(personName, personAge);
                family.AddMember(person);
            }

            var oldestPerson = family.GetOldestPerson();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
