using AbstractFactory.ExampleOne.Problem.Interfaces;

namespace AbstractFactory.ExampleOne.Problem.Components.CheckBoxes;

public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        // operations for light checkbox
        Console.WriteLine("Light Checkbox Rendered");
    }
}