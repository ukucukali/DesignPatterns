using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.Components.Buttons;

public class DarkButton : IButton
{
    public void Render()
    {
        // operations for dark button
        Console.WriteLine("Dark Button Rendered");
    }
}