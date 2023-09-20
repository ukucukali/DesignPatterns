using Factory.ExampleOne.Solution.Interfaces;
using Factory.ExampleOne.Solution.PaymentMethods;

namespace Factory.ExampleOne.Solution.FactoryMethods;

public class PayPalPaymentFactory: IPaymentProcessorFactory
{
    public PaymentMethod CreatePaymentMethod()
    {
        //logic and processes for paypal payment
        return new PayPalPayment();
    }
}