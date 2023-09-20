using AbstractFactory.ExampleOne.Problem.Interfaces;

namespace AbstractFactory.ExampleOne.Problem.Components.Buttons;

public class DarkButton : IButton
{
    public void Render()
    {
        // operations for dark button
        Console.WriteLine("Dark Button Rendered");
    }
}