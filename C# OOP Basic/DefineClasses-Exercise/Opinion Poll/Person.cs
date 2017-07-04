using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opinion_Poll
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
