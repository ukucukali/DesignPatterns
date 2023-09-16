using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.Components.CheckBoxes;

public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        // operations for light checkbox
        Console.WriteLine("Light Checkbox Rendered");
    }
}