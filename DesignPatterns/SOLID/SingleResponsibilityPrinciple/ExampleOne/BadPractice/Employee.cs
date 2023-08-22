namespace SingleResponsibilityPrinciple.ExampleOne.BadPractice;

public class Employee
{
    public double CalculatePayment(Money money)
    {
        //business logic made here

        return 0;
    }

    public Employee Save(Employee employee)
    {
        //persistence implementation, saving employees, made here
        return new Employee();
    }

    // There are  two responsibilities for this class. calculating salary and also database 
}

public class Money
{
}