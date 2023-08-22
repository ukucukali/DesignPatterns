namespace InterfaceSegregationPrinciple.ExampleOne.GoodPractice.Interfaces;

public interface IPartTimeEmployee
{
    double HourlyRate { get; set; }

    double HoursInMonth { get; set; }

    double CalculateWorkedSalary();
}