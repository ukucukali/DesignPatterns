namespace LiskovSubstitutionPrinciple.Models.ExampleOne.BadPractice;

public class Contractual : Employee
{
    public override string GetProjectDetails(int employeeId)
    {
        //base class information about project will change afterwards
        return "Contractual employee project details";
    }
}