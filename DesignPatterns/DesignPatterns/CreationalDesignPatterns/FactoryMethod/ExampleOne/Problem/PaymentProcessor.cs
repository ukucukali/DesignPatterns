namespace FactoryMethod.ExampleOne.Problem;

public class PaymentProcessor
{
    // This type of implementation causes unnecessary code duplications and tight coupling
    public void ProcessCreditCardPayment()
    {
        // Logic to process credit card payment
    }

    public void ProcessPayPalPayment()
    {
        // Logic to process PayPal payment
    }

    public void ProcessBitcoinPayment()
    {
        // Logic to process Bitcoin payment
    }
}