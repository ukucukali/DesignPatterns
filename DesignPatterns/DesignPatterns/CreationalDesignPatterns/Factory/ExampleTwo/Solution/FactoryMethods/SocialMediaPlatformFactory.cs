using Factory.ExampleTwo.Solution.Interfaces;
using Factory.ExampleTwo.Solution.MessagingPlatforms;

namespace Factory.ExampleTwo.Solution.FactoryMethods;

public class SocialMediaPlatformFactory : MessagingPlatformFactory
{
    public override MessagingPlatform CreateMessagingPlatform()
    {
        return new SocialMediaPlatform();
    }
}