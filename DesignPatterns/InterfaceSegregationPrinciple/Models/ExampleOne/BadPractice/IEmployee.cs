namespace InterfaceSegregationPrinciple.Models.BadPractice;

public interface IEmployee
{
    string Id { get; set; }
    
    string Name { get; set; }
    
    string Email { get; set; }
    
    double MonthlySalary { get; set; }
    
    double ExtraPayments { get; set; }

    double OverTimeHours { get; set; }
    
     double OverTimeRate { get; set; }
     
    double HourlyRate { get; set; }
    
    double HoursInMonth { get; set; }

    double CalculateNetSalary();
    
    double CalculateWorkedSalary();
}