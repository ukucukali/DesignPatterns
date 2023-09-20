using AbstractFactoryMethod.ExampleTwo.Problem.Interfaces;

namespace AbstractFactoryMethod.ExampleTwo.Problem.Components.Storage;

public class DesktopStorage : IStorage
{
    public void StoreData()
    {
        // data store operations 
        
        Console.WriteLine("Storing data on a desktop storage device.");
    }
}