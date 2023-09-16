using AbstractFactoryMethod.ExampleOne.Solution.Components.Buttons;
using AbstractFactoryMethod.ExampleOne.Solution.Components.CheckBoxes;
using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.Components.Themes;

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