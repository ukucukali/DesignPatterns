using System.Net.Mail;

namespace SOLID.SingleResponsibilityPrinciple.Models.ExampleTwo.GoodPractice;

public interface IEmailService
{
    public void Send();
}