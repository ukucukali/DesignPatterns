namespace Polymorphism.ExampleOne;

public class FullTimeEmployee : Employee
{
    public decimal MonthlySalary { get; set; }

    public FullTimeEmployee(string name, decimal monthlySalary)
    {
        Name = name;
        MonthlySalary = monthlySalary;
    }

    public override decimal CalculateSalary()
    {
        return MonthlySalary;
    }
}