using AbstractFactoryMethod.ExampleOne.Solution.Components.Themes;
using AbstractFactoryMethod.ExampleOne.Solution.Interfaces;

namespace AbstractFactoryMethod.ExampleOne.Solution.AbstractFactoryMethods;

public class LightThemeFactory : IThemeFactory
{
    public ITheme CreateTheme()
    {
        Console.WriteLine("Light Theme Created");
        return new LightTheme();
    }
}