using AbstractFactory.ExampleTwo.Solution.Interfaces;

namespace AbstractFactory.ExampleTwo.Solution.Components.Storage;

public class LaptopStorage : IStorage
{
    public void StoreData()
    {
        // data store operations 
        
        Console.WriteLine("Storing data on a laptop storage device.");
    }
}