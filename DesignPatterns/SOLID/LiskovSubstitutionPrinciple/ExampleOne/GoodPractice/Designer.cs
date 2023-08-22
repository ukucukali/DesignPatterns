namespace LiskovSubstitutionPrinciple.ExampleOne.GoodPractice;

public class Designer:Employee
{
    public override string GetProjectDetails(int employeeId)
    {
        base.GetProjectDetails(employeeId);
        
        //editing base projects design details 
        return "Designer project details";
    }
}