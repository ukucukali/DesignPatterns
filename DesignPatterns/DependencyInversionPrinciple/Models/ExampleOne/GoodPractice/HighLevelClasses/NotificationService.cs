namespace DependencyInversionPrinciple.Models.ExampleOne.GoodPractice.HighLevelClasses;

public class NotificationService
{
    private ILogger _logger;
    private IEmailService _emailService;
    
    // high level classes depends on low level classes by their interface.
    // it became as loose coupling between low and high level classes.
    // it makes easier to maintain low level classes without maintain high level class
    
    public NotificationService(ILogger logger , IEmailService emailService )
    {
        _logger = logger;
        _emailService = emailService;
    }

    public void NotifyUser(string emailAddress, string message)
    {
        _logger.Log($"Preparing to notify {emailAddress}");
        
        _emailService.SendEmail(emailAddress, message);
        
        _logger.Log($"Notification sent to {emailAddress}");
    }
}