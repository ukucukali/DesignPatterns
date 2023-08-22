namespace OpenClosedPrinciple.ExampleTwo.GoodPractice;

public class Rectangle : Shape
{
    public double Height { get; set; }

    public double Width { get; set; }

    public override double Area()
    {
        // Rectangle area calculations
        return Height * Width;
    }
}