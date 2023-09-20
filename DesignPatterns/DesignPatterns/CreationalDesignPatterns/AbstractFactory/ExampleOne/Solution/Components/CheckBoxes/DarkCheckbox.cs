using AbstractFactory.ExampleOne.Solution.Interfaces;

namespace AbstractFactory.ExampleOne.Solution.Components.CheckBoxes;

public class DarkCheckbox: ICheckbox
{
    public void Render()
    {
        // operations for dark checkbox
        Console.WriteLine("Dark Checkbox Rendered");
    }
}