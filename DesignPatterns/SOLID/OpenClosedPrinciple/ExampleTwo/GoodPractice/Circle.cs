namespace OpenClosedPrinciple.ExampleTwo.GoodPractice;

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        // Circle area calculations

        return Radius * Radius * Math.PI;
    }
}