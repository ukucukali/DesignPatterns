using FactoryMethod.ExampleOne.Solution.Interfaces;
using FactoryMethod.ExampleOne.Solution.PaymentMethods;

namespace FactoryMethod.ExampleOne.Solution.FactoryMethods;

public class CreditCardPaymentFactory : IPaymentProcessorFactory
{
    public PaymentMethod CreatePaymentMethod()
    {
        //logic and processes for creditcard payment
        return new CreditCardPayment();
    }
}