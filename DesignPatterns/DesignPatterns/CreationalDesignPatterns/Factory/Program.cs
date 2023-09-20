using Factory.ExampleOne.Problem;
using Factory.ExampleOne.Solution;
using Factory.ExampleOne.Solution.FactoryMethods;
using Factory.ExampleOne.Solution.Interfaces;
using Factory.ExampleTwo.Problem;
using Factory.ExampleTwo.Solution;
using Factory.ExampleTwo.Solution.FactoryMethods;
using Factory.ExampleTwo.Solution.Interfaces;

/*
  STRUCTURE
 * Create main abstract/interface class
 * Create concrete methods related to main class with all the logic and processes
 * Create creator( MainProductName + Factory) interface which is common to all objects that can be produced by the creator and its subclasses.
 * Create Factory classes for each subclasses (subclassName + Factory ), apply necessary controls etc. and return new instances of them.
 * Create new instance of needed subclasses factory class and it will be treated as main class
 */

#region Example One - Payment Processor

#region Problem

PaymentProcessor paymentProcessor = new PaymentProcessor();
paymentProcessor.ProcessCreditCardPayment();
paymentProcessor.ProcessPayPalPayment();
paymentProcessor.ProcessBitcoinPayment();

#endregion

#region Solution

// returns creditcard payment instance but treated as payment method so PaymentMethod will work according to type of a factory method used.
IPaymentProcessorFactory paymentProcessorFactory1 = new CreditCardPaymentFactory();
PaymentMethod paymentMethod1 = paymentProcessorFactory1.CreatePaymentMethod();
Console.WriteLine(paymentMethod1.ProcessPayment());

// returns bitcoin payment instance but treated as payment method so PaymentMethod will work according to type of a factory method used.
IPaymentProcessorFactory paymentProcessorFactory2 = new BitcoinPaymentFactory();
PaymentMethod paymentMethod2 = paymentProcessorFactory2.CreatePaymentMethod();
Console.WriteLine(paymentMethod2.ProcessPayment());

// returns paypal payment instance but treated as payment method so PaymentMethod will work according to type of a factory method used.
IPaymentProcessorFactory paymentProcessorFactory3 = new PayPalPaymentFactory();
PaymentMethod paymentMethod3 = paymentProcessorFactory3.CreatePaymentMethod();
Console.WriteLine(paymentMethod3.ProcessPayment());

#endregion

#endregion

Console.WriteLine("*****************************");

#region Example Two - Message Service

#region Problem

MessagingService messagingService = new MessagingService();
Console.WriteLine(messagingService.SendSms("SMS sent"));
Console.WriteLine(messagingService.SendEmail("Email sent"));
Console.WriteLine(messagingService.SendSocialMediaMessage("Social Media Message sent"));

#endregion

Console.WriteLine("------------------------------");

#region Solution

/*
  STEPS
 * Create instance of the factory that be used
 * Use method to create instance of the class or existing objects from a cache or another source that be used in process.
 * Now it is possible to use methods are needed
 */

MessagingPlatformFactory messagingPlatformFactory1 = new EmailPlatformFactory();
MessagingPlatform messagingPlatform1 = messagingPlatformFactory1.CreateMessagingPlatform();
Console.WriteLine(messagingPlatform1.SendMessage("Email sent"));

MessagingPlatformFactory messagingPlatformFactory2 = new SmsPlatformFactory();
MessagingPlatform messagingPlatform2 = messagingPlatformFactory2.CreateMessagingPlatform();
Console.WriteLine(messagingPlatform2.SendMessage("Sms sent"));

MessagingPlatformFactory messagingPlatformFactory3 = new SocialMediaPlatformFactory();
MessagingPlatform messagingPlatform3 = messagingPlatformFactory3.CreateMessagingPlatform();
Console.WriteLine(messagingPlatform3.SendMessage("Social Media Platform message sent"));

#endregion

#endregion