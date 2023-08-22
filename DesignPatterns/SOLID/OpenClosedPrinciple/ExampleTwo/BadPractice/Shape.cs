namespace OpenClosedPrinciple.ExampleTwo.BadPractice;

public class Shape
{
    public double Area(Shape shape)
    {
        double area = 0;

        if (shape is Rectangle)
        {
            Rectangle rectangle = new();
            // Rectangle area calculations 
        }
        else if (shape is Circle)
        {
            // Square area calculations
        }
        else
        {
            //Everytime a new shape added this method should be edited
        }

        return area;
    }
}

public class Rectangle
{
    public double Height { get; set; }

    public double Width { get; set; }
    
    // Rectangle Properties 
}

public class Circle
{
    // Circle Properties 
}