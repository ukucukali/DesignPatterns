using AbstractFactory.ExampleTwo.Solution.Interfaces;

namespace AbstractFactory.ExampleTwo.Solution.Components.Processor;

public class LaptopProcessor : IProcessor
{
    public void PerformCalculations()
    {
        // Laptop Processor operations
        
        Console.WriteLine("Performing calculations on a laptop processor.");
    }
}