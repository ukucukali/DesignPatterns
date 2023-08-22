namespace LiskovSubstitutionPrinciple.ExampleOne.BadPractice;

public class Designer:Employee
{
    public override string GetProjectDetails(int employeeId)
    {
        // code is override base  project details
        return "Designer project details";
    }
}