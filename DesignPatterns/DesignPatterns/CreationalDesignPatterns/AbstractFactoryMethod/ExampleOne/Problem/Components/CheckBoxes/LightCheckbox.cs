using AbstractFactoryMethod.ExampleOne.Problem.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Problem.Components.CheckBoxes;

public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        // operations for light checkbox
        Console.WriteLine("Light Checkbox Rendered");
    }
}