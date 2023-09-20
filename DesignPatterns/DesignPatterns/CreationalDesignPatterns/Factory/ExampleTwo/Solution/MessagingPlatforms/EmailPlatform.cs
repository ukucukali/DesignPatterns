namespace Factory.ExampleTwo.Solution.MessagingPlatforms;

public class EmailPlatform : MessagingPlatform
{
    public override string SendMessage(string message)
    {
        return message;
    }
}