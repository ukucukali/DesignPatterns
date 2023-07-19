namespace DependencyInversionPrinciple.Models.ExampleOne.GoodPractice;

public class EmailService : IEmailService
{
    public void SendEmail(string emailAddress, string message) =>
        Console.WriteLine($"Sending an email to {emailAddress}: {message}");
}