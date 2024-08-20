using DemoLibrary.Abstractions;
using DemoLibrary.Implementations;

namespace DemoLibrary.RefinedAbstractions;

/// <summary>
/// You can extend the Abstraction without changing the Implementation classes (in our example for different payment methods).
/// </summary>
public class CreditCardProcessor : PaymentProcessor
{
    public CreditCardProcessor(IPaymentGateway paymentGateway) : base(paymentGateway)
    {
    }

    public override void ProcessPayment(decimal amount, string data)
    {
        base._paymentGateway.AuthorizePayment(amount, data);
        base._paymentGateway.CapturePayment();
        Console.WriteLine("Credit card payment process done!");
    }
}
