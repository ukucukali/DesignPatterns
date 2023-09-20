using AbstractFactory.ExampleOne.Solution.Components.Buttons;
using AbstractFactory.ExampleOne.Solution.Components.CheckBoxes;
using AbstractFactory.ExampleOne.Solution.Interfaces;

namespace AbstractFactory.ExampleOne.Solution.Components.Themes;

public class LightTheme : ITheme
{
    public IButton CreateButton()
    {
        Console.WriteLine("Light Button Created");
        return new LightButton();
    }

    public ICheckbox CreateCheckbox()
    {
        Console.WriteLine("Light Checkbox Created");
        return new LightCheckbox();
    }
}