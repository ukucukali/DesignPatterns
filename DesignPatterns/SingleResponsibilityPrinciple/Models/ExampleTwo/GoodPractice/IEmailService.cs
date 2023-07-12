using System.Net.Mail;

namespace SingleResponsibilityPrinciple.Models.ExampleTwo.GoodPractice;

public interface IEmailService
{
    public void Send();
}