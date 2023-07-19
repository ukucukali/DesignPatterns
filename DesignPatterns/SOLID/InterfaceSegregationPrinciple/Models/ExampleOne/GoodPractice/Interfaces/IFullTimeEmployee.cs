namespace InterfaceSegregationPrinciple.Models.ExampleOne.GoodPractice.Interfaces;

public interface IFullTimeEmployee
{
    double MonthlySalary { get; set; }
    
    double ExtraPayments { get; set; }

    double OverTimeHours { get; set; }
    
    double OverTimeRate { get; set; }
    
    double CalculateNetSalary();
}