namespace AbstractFactory.ExampleOne.Solution.Interfaces;

public interface ITheme
{
    IButton CreateButton();
    
    ICheckbox CreateCheckbox();
}