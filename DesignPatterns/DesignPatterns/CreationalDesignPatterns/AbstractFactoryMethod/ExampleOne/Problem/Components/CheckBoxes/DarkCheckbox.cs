using AbstractFactoryMethod.ExampleOne.Problem.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Problem.Components.CheckBoxes;

public class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        // operations for dark checkbox
        Console.WriteLine("Dark Checkbox Rendered");
    }
}