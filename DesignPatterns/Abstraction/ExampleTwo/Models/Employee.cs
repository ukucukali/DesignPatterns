﻿namespace Abstraction.ExampleTwo.Models;

public abstract class Employee
{
    public string Name { get; set; }
    
    public string EmployeeId { get; set; }

    public Employee(string name, string employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    // Abstract method to calculate the monthly salary
    public abstract decimal CalculateSalary();
}