using AbstractFactory.ExampleTwo.Problem.Interfaces;

namespace AbstractFactory.ExampleTwo.Problem.Components.Processor;

public class LaptopProcessor : IProcessor
{
    public void PerformCalculations() 
    {
        // Laptop DesktopProcessor operations
        
        Console.WriteLine("Performing calculations on a Laptop processor.");
    }
}