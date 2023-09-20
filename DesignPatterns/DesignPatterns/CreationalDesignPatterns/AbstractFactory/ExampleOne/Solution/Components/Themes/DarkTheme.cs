using AbstractFactory.ExampleOne.Solution.Components.Buttons;
using AbstractFactory.ExampleOne.Solution.Components.CheckBoxes;
using AbstractFactory.ExampleOne.Solution.Interfaces;

namespace AbstractFactory.ExampleOne.Solution.Components.Themes;

public class DarkTheme : ITheme
{
    public IButton CreateButton()
    {
        Console.WriteLine("Dark Button Created");
        return new DarkButton();
    }

    public ICheckbox CreateCheckbox()
    {
        Console.WriteLine("Dark Checkbox Created");
        return new DarkCheckbox();
    }
}