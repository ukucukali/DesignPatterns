namespace Inheritance.ExampleOne;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int numberOfDoors)
        : base(make, model)
    {
        NumberOfDoors = numberOfDoors;
    }

    public void Accelerate()
    {
        Console.WriteLine($"The {Make} {Model} is accelerating.");
    }
}