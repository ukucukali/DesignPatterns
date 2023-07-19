using DependencyInversionPrinciple.Models.ExampleTwo.GoodPractice.LowLevelClasses.Interfaces;

namespace DependencyInversionPrinciple.Models.ExampleTwo.GoodPractice;

public class PaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        // Payment processing steps
        Console.WriteLine($"Processing payment: ${amount}");
    }
}