namespace Inheritance.ExampleTwo;

public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountNumber, decimal initialBalance, decimal overdraftLimit) : base(accountNumber, initialBalance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public decimal OverdraftLimit { get; set; }
    
    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance + OverdraftLimit)
            Balance -= amount;
        
        else
            Console.WriteLine("Insufficient balance.");
    }

    public override void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine($"Overdraft Limit: ${OverdraftLimit:F2}");
    }
}