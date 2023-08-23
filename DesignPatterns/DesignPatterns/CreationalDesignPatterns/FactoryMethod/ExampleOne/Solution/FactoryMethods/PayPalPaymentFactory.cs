using FactoryMethod.ExampleOne.Solution.Interfaces;
using FactoryMethod.ExampleOne.Solution.PaymentMethods;

namespace FactoryMethod.ExampleOne.Solution.FactoryMethods;

public class PayPalPaymentFactory: IPaymentProcessorFactory
{
    public PaymentMethod CreatePaymentMethod()
    {
        //logic and processes for paypal payment
        return new PayPalPayment();
    }
}