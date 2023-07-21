namespace Encapsulation.ExampleOne;

public class BankAccount
{
    // Main balance cannot be directly access by other methods or classes every operation is done by related methods
    private decimal _balance;

    public decimal Balance
    {
        get => _balance;
        private set => _balance = Math.Max(0, value);
    }

    // Use the property setter to initialize the balance
    public BankAccount(decimal initialBalance) => Balance = initialBalance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            Balance += amount;
        else
            Console.WriteLine("Invalid amount for deposit.");
    }

    // Public method to withdraw funds from the account
    public void Withdraw(decimal amount)
    {
        // Use the property setter to update the balance
        if (amount > 0)
            Balance -= amount;
        else
            Console.WriteLine("Invalid amount for withdrawal.");
    }

    // Public method to display the account balance
    public void DisplayBalance() => Console.WriteLine($"Account Balance: ${Balance:F2}");
}