using DemoLibrary.Implementations;

namespace DemoLibrary.Abstractions;
/// <summary>
/// The Abstraction defines the interface for the "control" part of the two
/// class hierarchies. It maintains a reference to an object of the
/// Implementation hierarchy and delegates all of the real work to this
/// object.
/// This class defines the interface for the payment processing logic
/// </summary>

public class PaymentProcessor
{
    protected IPaymentGateway _paymentGateway;

    public PaymentProcessor(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public virtual void ProcessPayment(decimal amount, string data)
    {
        _paymentGateway.AuthorizePayment(amount, data);
        _paymentGateway.CapturePayment();
        Console.WriteLine("Payment process done!");
    }
}
