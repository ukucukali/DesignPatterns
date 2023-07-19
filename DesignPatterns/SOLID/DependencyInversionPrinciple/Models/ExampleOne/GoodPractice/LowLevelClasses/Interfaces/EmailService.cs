namespace DependencyInversionPrinciple.Models.ExampleOne.GoodPractice;

public interface IEmailService
{
    void SendEmail(string emailAddress, string message);
}