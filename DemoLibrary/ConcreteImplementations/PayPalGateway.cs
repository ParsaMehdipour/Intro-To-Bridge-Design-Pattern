using DemoLibrary.Implementations;

namespace DemoLibrary.ConcreteImplementations;

/// <summary>
/// Each Concrete Implementation corresponds to a specific platform and
/// implements the Implementation interface using that platform's API.
/// The "Concrete Implementations" of the payment gateway
/// </summary>
public class PayPalGateway : IPaymentGateway
{
    public void AuthorizePayment(decimal amount, string data)
    {
        // Implement PayPal's authorization process for credit card payments
        Console.WriteLine("PayPal : Approved");
    }

    public void CapturePayment()
    {
        // Implement PayPal's capture process
        Console.WriteLine("PayPal : Captured");
    }
}
