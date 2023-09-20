using AbstractFactory.ExampleTwo.Problem.Interfaces;

namespace AbstractFactory.ExampleTwo.Problem.Components.Storage;

public class DesktopStorage : IStorage
{
    public void StoreData()
    {
        // data store operations 
        
        Console.WriteLine("Storing data on a desktop storage device.");
    }
}