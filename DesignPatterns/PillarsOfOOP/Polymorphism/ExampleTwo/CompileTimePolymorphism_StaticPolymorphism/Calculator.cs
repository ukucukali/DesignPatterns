namespace Polymorphism.ExampleTwo.CompileTimePolymorphism_StaticPolymorphism;

public class Calculator
{
        // Method overloading for addition with two integers
        public int Add(int a, int b)
        {
            return a + b;
        }
    
        // Method overloading for addition with three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    
        // Method overloading for addition with two decimal numbers
        public double Add(double a, double b)
        {
            return a + b;
        }
    
        // Method overloading for addition with an array of integers
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
}