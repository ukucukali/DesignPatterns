using AbstractFactoryMethod.ExampleTwo.Problem.Interfaces;

namespace AbstractFactoryMethod.ExampleTwo.Problem.Components.Processor;

public class DesktopProcessor : IProcessor
{
    public void PerformCalculations()
    {
        // Desktop DesktopProcessor operations
        
        Console.WriteLine("Performing calculations on a desktop processor.");
    }
}