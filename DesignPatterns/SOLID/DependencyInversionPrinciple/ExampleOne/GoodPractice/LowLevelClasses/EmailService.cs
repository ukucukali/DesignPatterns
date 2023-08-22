using DependencyInversionPrinciple.ExampleOne.GoodPractice.LowLevelClasses.Interfaces;

namespace DependencyInversionPrinciple.ExampleOne.GoodPractice.LowLevelClasses;

public class EmailService : IEmailService
{
    public void SendEmail(string emailAddress, string message) =>
        Console.WriteLine($"Sending an email to {emailAddress}: {message}");
}