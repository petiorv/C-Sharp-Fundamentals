using System;

public class Student : Human
{
    private string facultyNum;

    public Student(string firstName, string lastName, string facultyNum)
        : base (firstName, lastName)
    {
        this.FacultyNum = facultyNum;
    }

    public string FacultyNum
    {
        get
        {
            return this.facultyNum;
        }
        set
        {
            if (value.Length < 5 && value.Length > 10)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNum = value;
        }
    }
}
