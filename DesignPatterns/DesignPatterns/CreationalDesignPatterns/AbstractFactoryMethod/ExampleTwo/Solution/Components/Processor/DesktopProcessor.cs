using AbstractFactoryMethod.ExampleTwo.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleTwo.Solution.Components.Processor;

public class DesktopProcessor : IProcessor
{
    public void PerformCalculations()
    {
        // Desktop DesktopProcessor operations

        Console.WriteLine("Performing calculations on a desktop processor.");
    }
}