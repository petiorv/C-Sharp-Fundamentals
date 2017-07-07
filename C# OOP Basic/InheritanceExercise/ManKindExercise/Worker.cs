using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private double workHoursPerDay;
    private decimal salaryPerHour;
    
    public Worker(string firstName, string lastName, decimal weekSalary, double hours) 
        : base (firstName, lastName)
    {
        this.WeekSalary = weekSalary;
    }

    public 

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }
    public double WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"First Name: {this.FirstName}");
        result.AppendLine($"Last Name: {this.LastName}");
        result.AppendLine($"Week Salary: {this.WeekSalary}");
        result.AppendLine($"Hours per day: {this.WorkHoursPerDay}");
        result.AppendLine($"Salary per hour: {this.s}");
        return "";
    }
}

