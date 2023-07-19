namespace SingleResponsibilityPrinciple.Models.ExampleOne.GoodPractice;

//To enhance modularity and reduce the heavy load on individual classes,
//we can create two separate classes that divide the workflow and distribute responsibilities.

public class Employee
{
    public double CalculatePayment(Money money)
    {
        //business logic made here

        return 0;
    }
}


public class EmployeeRepository
{
    public Employee Save(Employee employee)
    {
        //persistence implementation, saving employees, made here
        return new Employee();
    }
}