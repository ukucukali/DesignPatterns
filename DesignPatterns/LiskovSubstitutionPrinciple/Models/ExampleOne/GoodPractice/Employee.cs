﻿namespace LiskovSubstitutionPrinciple.Models.ExampleOne.GoodPractice;

public class Employee
{
    public virtual string GetProjectDetails(int employeeId)
    {
        return "Base project details";
    }
}