using InterfaceSegregationPrinciple.ExampleOne.GoodPractice.Interfaces;

namespace InterfaceSegregationPrinciple.ExampleOne.GoodPractice;

public class FullTimeEmployee : BaseEmployee, IFullTimeEmployee
{
    //Properties and methods are all related to Full time employee class
    public double MonthlySalary { get; set; }

    public double ExtraPayments { get; set; }

    public double OverTimeHours { get; set; }

    public double OverTimeRate { get; set; }

    public double CalculateNetSalary() => MonthlySalary + ExtraPayments + (OverTimeHours * OverTimeRate);
}