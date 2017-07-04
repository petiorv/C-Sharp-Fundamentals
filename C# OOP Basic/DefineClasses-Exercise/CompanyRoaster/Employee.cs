using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoaster
{
    public class Employee
    {
        private string name;
        private int age;
        private string email;
        private string position;
        private string department;
        private decimal salary;


        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.age = -1;
            this.email = "n/a";
        }        
        
        public int Age
        {           
            set
            {
                this.age = value;
            }
        }

        public string Email
        {           
            set
            {
                this.email = value;
            }
        }   
        
        public string Department
        {
            get
            {
                return this.department;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        public string PrintEmployeeInfo()
        {
            return $"{this.name} {this.salary:f2} {this.email} {this.age}";
        }



    }
}

