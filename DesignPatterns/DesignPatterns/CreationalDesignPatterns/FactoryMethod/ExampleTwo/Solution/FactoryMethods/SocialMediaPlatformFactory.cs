using FactoryMethod.ExampleTwo.Solution.Interfaces;
using FactoryMethod.ExampleTwo.Solution.MessagingPlatforms;

namespace FactoryMethod.ExampleTwo.Solution.FactoryMethods;

public class SocialMediaPlatformFactory : MessagingPlatformFactory
{
    public override MessagingPlatform CreateMessagingPlatform()
    {
        return new SocialMediaPlatform();
    }
}