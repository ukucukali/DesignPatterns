namespace DependencyInversionPrinciple.ExampleOne.BadPractice.LowLevelClasses;

public class EmailService
{
    
    public void SendEmail(string emailAddress, string message) => Console.WriteLine($"Sending an email to {emailAddress}: {message}");
    
}