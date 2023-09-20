using AbstractFactoryMethod.ExampleTwo.Solution.Components.Processor;
using AbstractFactoryMethod.ExampleTwo.Solution.Components.Storage;
using AbstractFactoryMethod.ExampleTwo.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleTwo.Solution.AbstractFactoryMethods;

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