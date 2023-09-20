using AbstractFactory.ExampleOne.Problem.Interfaces;

namespace AbstractFactory.ExampleOne.Problem.Components.Buttons;

public class LightButton : IButton
{
    public void Render()
    {
        // operations for light button
        Console.WriteLine("Light Button Rendered");
    }
}