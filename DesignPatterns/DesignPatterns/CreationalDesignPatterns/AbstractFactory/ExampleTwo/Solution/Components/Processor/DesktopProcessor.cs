using AbstractFactory.ExampleTwo.Solution.Interfaces;

namespace AbstractFactory.ExampleTwo.Solution.Components.Processor;

public class DesktopProcessor : IProcessor
{
    public void PerformCalculations()
    {
        // Desktop DesktopProcessor operations

        Console.WriteLine("Performing calculations on a desktop processor.");
    }
}