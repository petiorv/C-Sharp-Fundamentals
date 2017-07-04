namespace Opinion_Poll
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestPerson()
        {
            return this.members
                    .OrderByDescending(a => a.Age)
                    .FirstOrDefault();
        }

        public List<Person> GetOlderThan30()
        {
            return this.members.Where(a => a.Age > 30).OrderBy(n => n.Name).ToList();
        }
    }
}
