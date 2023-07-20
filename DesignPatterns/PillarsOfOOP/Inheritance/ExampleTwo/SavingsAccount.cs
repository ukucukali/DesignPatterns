namespace Inheritance.ExampleTwo;

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate) : base(accountNumber, initialBalance)
    {
        InterestRate = interestRate;
    }

    public decimal InterestRate { get; set; }
    public override void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine($"Interest Rate: {InterestRate * 100:F2}%");
    }
}