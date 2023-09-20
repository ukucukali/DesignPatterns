using AbstractFactory.ExampleOne.Solution.Interfaces;

namespace AbstractFactory.ExampleOne.Solution.Components.CheckBoxes;

public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        // operations for light checkbox
        Console.WriteLine("Light Checkbox Rendered");
    }
}