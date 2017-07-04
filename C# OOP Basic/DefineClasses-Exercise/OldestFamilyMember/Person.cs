namespace OldestFamilyMember
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}
