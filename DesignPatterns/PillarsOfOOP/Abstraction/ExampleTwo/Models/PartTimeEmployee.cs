using Abstraction.ExampleTwo.Interfaces;

namespace Abstraction.ExampleTwo.Models;

public class PartTimeEmployee : Employee, IEmployeeDetails
{
    public PartTimeEmployee(string name, string employeeId, decimal hourlyRate, int hoursWorked) : base(name,
        employeeId)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }
    // this property wasn't initialized in base class because only in this class it will be used
    public decimal HourlyRate { get; set; }
    
    // this property wasn't initialized in base class because only in this class it will be used 
    public int HoursWorked { get; set; }
    
    // abstract classes allow us to override methods that on each subclass base operations
    // would be done without any problem
    public override decimal CalculateSalary() => HourlyRate * HoursWorked;

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine(
            $"Part-time Employee: {Name}\nID: {EmployeeId}, Hourly Rate: ${HourlyRate:F2}\nHours Worked: {HoursWorked}\nMonthly Salary: ${CalculateSalary():F2}\n");
    }
}