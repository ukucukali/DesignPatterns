namespace Polymorphism.ExampleTwo.RunTimePolymorphism_DynamicPolymorphism;

public class Motorcycle : Vehicle
{
    public override void DisplayFuelType()
    {
        Console.WriteLine("Fuel type: Petrol");
    }
}