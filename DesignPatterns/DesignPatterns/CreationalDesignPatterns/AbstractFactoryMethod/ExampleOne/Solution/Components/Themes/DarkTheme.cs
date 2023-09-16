using AbstractFactoryMethod.ExampleOne.Solution.Components.Buttons;
using AbstractFactoryMethod.ExampleOne.Solution.Components.CheckBoxes;
using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.Components.Themes;

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