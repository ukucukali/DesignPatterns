namespace LiskovSubstitutionPrinciple.Models.ExampleTwo.BadPractice;

public class Banana:Apple
{
    public override string GetName() => "Banana";
}