namespace FactoryMethod.ExampleOne.Solution.PaymentMethods;

public class CreditCardPayment : PaymentMethod
{
    public override string ProcessPayment()
    {
        return "Credit Card Payment Process started";
    }
}