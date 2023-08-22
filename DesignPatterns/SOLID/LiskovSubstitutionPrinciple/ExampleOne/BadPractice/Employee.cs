namespace LiskovSubstitutionPrinciple.ExampleOne.BadPractice;

public class Employee
{
    public virtual string GetProjectDetails(int employeeId)
    {
        return "Base project details";
    }
}