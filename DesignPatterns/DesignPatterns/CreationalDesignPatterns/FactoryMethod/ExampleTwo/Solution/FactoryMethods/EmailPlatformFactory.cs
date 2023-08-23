using FactoryMethod.ExampleTwo.Solution.Interfaces;
using FactoryMethod.ExampleTwo.Solution.MessagingPlatforms;

namespace FactoryMethod.ExampleTwo.Solution.FactoryMethods;

public class EmailPlatformFactory : MessagingPlatformFactory
{
    public override MessagingPlatform CreateMessagingPlatform()
    {
        return new EmailPlatform();
    }
}