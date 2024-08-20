using DemoLibrary.Implementations;

namespace DemoLibrary.ConcreteImplementations;

/// <summary>
/// Each Concrete Implementation corresponds to a specific platform and
/// implements the Implementation interface using that platform's API.
/// The "Concrete Implementations" of the payment gateway
/// </summary>
public class StripeGateway : IPaymentGateway
{
    public void AuthorizePayment(decimal amount, string data)
    {
        // Implement Stripe's authorization process for credit card payments
        Console.WriteLine("Stripe : Approved");
    }

    public void AuthorizePayment(decimal amount, string cardNumber, string expirationDate, string cvv)
    {
        // Implement Stripe's authorization process for credit card payments
        Console.WriteLine("Stripe : Approved");
    }

    public void CapturePayment()
    {
        // Implement PayPal's capture process
        Console.WriteLine("Stripe : Captured");
    }
}
