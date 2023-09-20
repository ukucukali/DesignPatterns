namespace Factory.ExampleTwo.Solution.MessagingPlatforms;

public class SmsPlatform : MessagingPlatform
{
    public override string SendMessage(string message)
    {
        return message;
    }
}