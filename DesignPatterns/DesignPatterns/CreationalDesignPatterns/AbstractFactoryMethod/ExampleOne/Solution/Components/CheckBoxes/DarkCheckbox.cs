using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.Components.CheckBoxes;

public class DarkCheckbox: ICheckbox
{
    public void Render()
    {
        // operations for dark checkbox
        Console.WriteLine("Dark Checkbox Rendered");
    }
}