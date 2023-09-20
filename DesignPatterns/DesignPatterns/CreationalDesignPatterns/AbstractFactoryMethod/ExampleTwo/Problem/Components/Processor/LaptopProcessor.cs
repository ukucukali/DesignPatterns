using AbstractFactoryMethod.ExampleTwo.Problem.Interfaces;

namespace AbstractFactoryMethod.ExampleTwo.Problem.Components.Processor;

public class LaptopProcessor : IProcessor
{
    public void PerformCalculations() 
    {
        // Laptop DesktopProcessor operations
        
        Console.WriteLine("Performing calculations on a Laptop processor.");
    }
}