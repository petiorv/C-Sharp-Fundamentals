using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;
    
    public Worker(string firstName, string lastName, decimal weekSalary, decimal hours) 
        : base (firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = hours;
        
        
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }
    public decimal WorkHoursPerDay
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
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.AppendLine($"Week Salary: {this.WeekSalary:F2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");

        decimal salaryPerHour = this.WeekSalary / (this.WorkHoursPerDay * 5);
        sb.Append($"Salary per hour: {salaryPerHour:F2}");
        return sb.ToString();
    }
}

