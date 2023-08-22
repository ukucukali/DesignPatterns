namespace DependencyInversionPrinciple.ExampleTwo.BadPractice.LowLevelClasses;

public class PaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        // Payment processing steps
        Console.WriteLine($"Processing payment: ${amount}");
    }
}