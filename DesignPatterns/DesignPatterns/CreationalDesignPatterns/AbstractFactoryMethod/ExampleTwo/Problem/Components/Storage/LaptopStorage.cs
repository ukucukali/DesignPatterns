using AbstractFactoryMethod.ExampleTwo.Problem.Interfaces;

namespace AbstractFactoryMethod.ExampleTwo.Problem.Components.Storage;

public class LaptopStorage : IStorage
{
    public void StoreData()
    {
        // Laptop data store operations 
        
        Console.WriteLine("Storing data on a Laptop storage device.");
    }
}