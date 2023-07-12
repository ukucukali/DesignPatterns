using System.Net.Mail;

namespace SingleResponsibilityPrinciple.Models.ExampleTwo.GoodPractice;

public class EmailService : IEmailService
{
    public SmtpClient Client { get; set; }

    public EmailService()
    {
        Client = CreateClient();
    }

    private SmtpClient CreateClient()
    {
        //necessary client operations
        return new SmtpClient();
    }

    public void Send()
    {
        //necessary operations to send an email
        Client.Send(new MailMessage());
    }
}