using FactoryMethod.ExampleOne.Solution.Interfaces;
using FactoryMethod.ExampleOne.Solution.PaymentMethods;

namespace FactoryMethod.ExampleOne.Solution.FactoryMethods;

public class BitcoinPaymentFactory : IPaymentProcessorFactory
{
    public PaymentMethod CreatePaymentMethod()
    {
        //logic and processes for Bitcoin payment
        return new BitcoinPayment();
    }
}