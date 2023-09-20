using AbstractFactory.ExampleTwo.Problem.Interfaces;

namespace AbstractFactory.ExampleTwo.Problem.Components.Processor;

public class DesktopProcessor : IProcessor
{
    public void PerformCalculations()
    {
        // Desktop DesktopProcessor operations
        
        Console.WriteLine("Performing calculations on a desktop processor.");
    }
}