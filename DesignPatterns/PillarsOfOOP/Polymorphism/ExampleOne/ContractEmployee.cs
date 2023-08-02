namespace Polymorphism.ExampleOne;

public class ContractEmployee : Employee
{
    public decimal ContractAmount { get; set; }

    public ContractEmployee(string name, decimal contractAmount)
    {
        Name = name;
        ContractAmount = contractAmount;
    }

    public override decimal CalculateSalary()
    {
        return ContractAmount;
    }
}