namespace DependencyInversionPrinciple.Models.ExampleOne.BadPractice.HighLevelClasses;

public class NotificationService
{
    private Logger _logger;
    private EmailService _emailService;

    // high level classes depends on low level concrete classes.
    // it causes tight coupling between low and high level classes.
    // it makes difficult to maintain low level classes without maintain high level class

    public NotificationService()
    {
        _logger = new Logger();
        _emailService = new EmailService();
    }

    public void NotifyUser(string emailAddress, string message)
    {
        _logger.Log($"Preparing to notify {emailAddress}");
        _emailService.SendEmail(emailAddress, message);
        _logger.Log($"Notification sent to {emailAddress}");
    }
}