using System;
using System.Text;
using System.Text.RegularExpressions;

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
            if (value.Length < 5 || value.Length > 10 || !Regex.IsMatch(value, @"[a-zA-Z0-9]{5,10}"))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNum = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.AppendLine($"Faculty number: {this.FacultyNum}");
        return sb.ToString();
    }
}
