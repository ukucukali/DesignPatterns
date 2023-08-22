namespace LiskovSubstitutionPrinciple.ExampleOne.GoodPractice;

public class Contractual : Employee
{
    public override string GetProjectDetails(int employeeId)
    {
        base.GetProjectDetails(employeeId);
        
        //editing base projects contractual details 
        return "Contractual employee project details";
    }
}