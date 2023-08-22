namespace DependencyInversionPrinciple.ExampleOne.GoodPractice.LowLevelClasses.Interfaces;

public interface IEmailService
{
    void SendEmail(string emailAddress, string message);
}