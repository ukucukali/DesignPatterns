namespace FactoryMethod.ExampleOne.Solution.PaymentMethods;

public class PayPalPayment : PaymentMethod
{
    public override string ProcessPayment()
    {
        return "PayPal Payment Process started";
    }
}