namespace Polymorphism.ExampleOne;

public class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }

    public PartTimeEmployee(string name, int workHours, decimal hourlyRate)
    {
        Name = name;
        WorkHours = workHours;
        HourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * WorkHours;
    }
}