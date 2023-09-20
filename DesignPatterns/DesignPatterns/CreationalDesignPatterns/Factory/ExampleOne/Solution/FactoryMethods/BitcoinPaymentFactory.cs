using Factory.ExampleOne.Solution.Interfaces;
using Factory.ExampleOne.Solution.PaymentMethods;

namespace Factory.ExampleOne.Solution.FactoryMethods;

public class BitcoinPaymentFactory : IPaymentProcessorFactory
{
    public PaymentMethod CreatePaymentMethod()
    {
        //logic and processes for Bitcoin payment
        return new BitcoinPayment();
    }
}