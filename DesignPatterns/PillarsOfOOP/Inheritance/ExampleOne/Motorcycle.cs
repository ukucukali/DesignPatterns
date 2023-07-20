namespace Inheritance.ExampleOne;

public class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; }

    public Motorcycle(string make, string model, bool hasSideCar) : base(make, model)
    {
        HasSideCar = hasSideCar;
    }

    public void Wheelie()
    {
        Console.WriteLine($"The {Make} {Model} is doing a wheelie!");
    }
}