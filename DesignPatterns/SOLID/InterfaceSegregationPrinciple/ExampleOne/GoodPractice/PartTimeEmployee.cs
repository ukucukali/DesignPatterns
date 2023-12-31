﻿using InterfaceSegregationPrinciple.ExampleOne.GoodPractice.Interfaces;

namespace InterfaceSegregationPrinciple.ExampleOne.GoodPractice;

public class PartTimeEmployee : BaseEmployee, IPartTimeEmployee
{
    //Properties and methods are all related to part time employee class
    public double HourlyRate { get; set; }

    public double HoursInMonth { get; set; }

    public double CalculateWorkedSalary() => HourlyRate * HoursInMonth;
}