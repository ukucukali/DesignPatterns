using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.Components.Buttons;

public class LightButton: IButton
{
    public void Render()
    {
        // operations for light button
        Console.WriteLine("Light Button Rendered");
    }
}