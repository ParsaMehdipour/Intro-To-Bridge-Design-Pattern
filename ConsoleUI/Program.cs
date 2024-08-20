// Client code
using DemoLibrary.Abstractions;
using DemoLibrary.ConcreteImplementations;
using DemoLibrary.Implementations;
using DemoLibrary.RefinedAbstractions;

IPaymentGateway stripeGateway = new StripeGateway();
PaymentProcessor creditCardProcessor = new CreditCardProcessor(stripeGateway);
creditCardProcessor.ProcessPayment(100.00m, "4111111111111111");


IPaymentGateway payPalGateway = new PayPalGateway();
PaymentProcessor payPalProcessor = new PayPalProcessor(payPalGateway);
payPalProcessor.ProcessPayment(50.00m, "example@email.com");