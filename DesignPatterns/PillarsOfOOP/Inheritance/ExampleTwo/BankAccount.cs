namespace Inheritance.ExampleTwo;

public class BankAccount
{ 
    public string AccountNumber { get; set; }

    public decimal Balance { get; set; }
    
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
    
    public virtual void Deposit(decimal amount) => Balance += amount;

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient balance.");
    }
    
    public virtual void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: ${Balance:F2}");
    }
}