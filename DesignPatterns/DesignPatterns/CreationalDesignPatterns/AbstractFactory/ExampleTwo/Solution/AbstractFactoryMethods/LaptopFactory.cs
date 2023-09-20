using AbstractFactory.ExampleTwo.Solution.Components.Processor;
using AbstractFactory.ExampleTwo.Solution.Components.Storage;
using AbstractFactory.ExampleTwo.Solution.Interfaces;

namespace AbstractFactory.ExampleTwo.Solution.AbstractFactoryMethods;

public class LaptopFactory : IComputerFactory
{
    public IProcessor CreateProcessor()
    {
        // operations before creating processor instance

        Console.WriteLine("Laptop processor created");
        
        return new LaptopProcessor();
    }

    public IStorage CreateStorage()
    {
        // operations before creating storage instance

        Console.WriteLine("Laptop storage created");
        
        return new LaptopStorage();
    }
}