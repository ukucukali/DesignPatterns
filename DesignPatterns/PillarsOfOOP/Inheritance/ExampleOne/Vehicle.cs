namespace Inheritance.ExampleOne;

public class Vehicle
{
    // Base properties contains general properties that every vehicle should have
    public string Make { get; set; }
    public string Model { get; set; }

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }
    
    // Base class contains general methods that every vehicle should have
    public void Start()
    {
        Console.WriteLine($"Starting the {Make} {Model}.");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping the {Make} {Model}.");
    }
    
}