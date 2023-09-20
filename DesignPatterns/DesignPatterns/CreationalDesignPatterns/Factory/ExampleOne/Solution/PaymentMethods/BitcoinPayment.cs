namespace Factory.ExampleOne.Solution.PaymentMethods;

public class BitcoinPayment : PaymentMethod
{
    public override string ProcessPayment()
    {
        return "Bitcoin Payment Process started";
    }
}