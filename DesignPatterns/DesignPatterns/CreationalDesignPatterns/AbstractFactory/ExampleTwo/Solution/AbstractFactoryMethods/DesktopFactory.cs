using AbstractFactory.ExampleTwo.Solution.Components.Processor;
using AbstractFactory.ExampleTwo.Solution.Components.Storage;
using AbstractFactory.ExampleTwo.Solution.Interfaces;

namespace AbstractFactory.ExampleTwo.Solution.AbstractFactoryMethods;

public class DesktopFactory : IComputerFactory
{
    public IProcessor CreateProcessor()
    {
        // operations before creating processor instance
        
        Console.WriteLine("Desktop processor created");
        
        return new DesktopProcessor();
    }

    public IStorage CreateStorage()
    {
        // operations before creating storage instance
        
        Console.WriteLine("Desktop storage created");
        
        return new DesktopStorage();
    }
}