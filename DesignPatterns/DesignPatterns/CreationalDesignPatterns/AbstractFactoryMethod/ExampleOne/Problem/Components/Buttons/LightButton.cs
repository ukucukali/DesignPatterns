using AbstractFactoryMethod.ExampleOne.Problem.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Problem.Components.Buttons;

public class LightButton : IButton
{
    public void Render()
    {
        // operations for light button
        Console.WriteLine("Light Button Rendered");
    }
}