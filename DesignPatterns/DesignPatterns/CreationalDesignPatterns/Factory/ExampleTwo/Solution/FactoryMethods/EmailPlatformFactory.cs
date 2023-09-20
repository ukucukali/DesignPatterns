using Factory.ExampleTwo.Solution.Interfaces;
using Factory.ExampleTwo.Solution.MessagingPlatforms;

namespace Factory.ExampleTwo.Solution.FactoryMethods;

public class EmailPlatformFactory : MessagingPlatformFactory
{
    public override MessagingPlatform CreateMessagingPlatform()
    {
        return new EmailPlatform();
    }
}