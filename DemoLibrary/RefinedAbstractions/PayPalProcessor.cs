using DemoLibrary.Abstractions;
using DemoLibrary.Implementations;

namespace DemoLibrary.RefinedAbstractions;

/// <summary>
/// You can extend the Abstraction without changing the Implementation classes (in our example for different payment methods).
/// </summary>
public class PayPalProcessor : PaymentProcessor
{
    public PayPalProcessor(IPaymentGateway paymentGateway) : base(paymentGateway)
    {
    }

    public override void ProcessPayment(decimal amount, string data)
    {
        base._paymentGateway.AuthorizePayment(amount, data);
        base._paymentGateway.CapturePayment();
        Console.WriteLine("PayPal Payment Process done!");
    }
}
