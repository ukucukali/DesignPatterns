using AbstractFactory.ExampleOne.Solution.Interfaces;

namespace AbstractFactory.ExampleOne.Solution.Components.Buttons;

public class LightButton: IButton
{
    public void Render()
    {
        // operations for light button
        Console.WriteLine("Light Button Rendered");
    }
}