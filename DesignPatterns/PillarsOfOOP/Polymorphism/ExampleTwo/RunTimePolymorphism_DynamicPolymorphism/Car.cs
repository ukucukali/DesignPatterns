namespace Polymorphism.ExampleTwo.RunTimePolymorphism_DynamicPolymorphism;

public class Car : Vehicle
{
    public override void DisplayFuelType()
    {
        Console.WriteLine("Fuel type: Gasoline");
    }
}