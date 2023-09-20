using AbstractFactoryMethod.ExampleTwo.Solution.Components.Processor;
using AbstractFactoryMethod.ExampleTwo.Solution.Components.Storage;
using AbstractFactoryMethod.ExampleTwo.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleTwo.Solution.AbstractFactoryMethods;

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