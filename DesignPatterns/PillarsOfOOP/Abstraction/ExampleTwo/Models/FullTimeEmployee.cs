using Abstraction.ExampleTwo.Interfaces;

namespace Abstraction.ExampleTwo.Models;

public class FullTimeEmployee : Employee, IEmployeeDetails
{
    public FullTimeEmployee(string name, string employeeId, decimal monthlySalary) : base(name, employeeId)
    {
        MonthlySalary = monthlySalary;
    }

    // this property wasn't initialized in base class because only in this class it will be used 
    public decimal MonthlySalary { get; set; }

    public override decimal CalculateSalary() => MonthlySalary;

    // abstract classes allow us to override methods that on each subclass base operations
    // would be done without any problem
    public void DisplayEmployeeDetails() =>
        Console.WriteLine($"Full-time Employee: {Name}\nID: {EmployeeId}\nMonthly Salary: ${MonthlySalary:F2}\n");
}