namespace Factory.ExampleTwo.Solution.MessagingPlatforms;

public class SocialMediaPlatform : MessagingPlatform
{
    public override string SendMessage(string message)
    {
        return message;
    }
}