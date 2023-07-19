namespace InterfaceSegregationPrinciple.Models.BadPractice;

public class PartTimeEmployee : IEmployee
{
    #region General properties for employees

    public string Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    #endregion


    #region Properties and Methods that only used for full time employee

    public double MonthlySalary { get; set; }

    public double ExtraPayments { get; set; }

    public double OverTimeHours { get; set; }

    public double OverTimeRate { get; set; }

    public double CalculateNetSalary() => MonthlySalary + ExtraPayments + (OverTimeHours * OverTimeRate);

    #endregion
    

    #region Properties and Methods that only used for part time employee

    public double HourlyRate { get; set; }

    public double HoursInMonth { get; set; }

    public double CalculateWorkedSalary() => HourlyRate * HoursInMonth;

    #endregion
}