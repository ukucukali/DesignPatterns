namespace DependencyInversionPrinciple.Models.ExampleTwo.GoodPractice.LowLevelClasses.Interfaces;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}