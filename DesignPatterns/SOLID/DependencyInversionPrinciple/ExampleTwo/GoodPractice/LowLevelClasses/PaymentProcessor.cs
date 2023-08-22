using DependencyInversionPrinciple.ExampleTwo.GoodPractice.LowLevelClasses.Interfaces;

namespace DependencyInversionPrinciple.ExampleTwo.GoodPractice.LowLevelClasses;

public class PaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        // Payment processing steps
        Console.WriteLine($"Processing payment: ${amount}");
    }
}