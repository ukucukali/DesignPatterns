using AbstractFactory.ExampleOne.Problem.Interfaces;

namespace AbstractFactory.ExampleOne.Problem.Components.CheckBoxes;

public class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        // operations for dark checkbox
        Console.WriteLine("Dark Checkbox Rendered");
    }
}