using AbstractFactory.ExampleTwo.Solution.Interfaces;

namespace AbstractFactory.ExampleTwo.Solution.Components.Storage;

public class DesktopStorage : IStorage
{
    public void StoreData()
    {
        // data store operations 
        
        Console.WriteLine("Storing data on a desktop storage device.");
    }
}