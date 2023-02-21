using dependency_injection;

internal class Program
{
    private static void Main(string[] args)
    {
        var checkout = new Checkout("PayPal");
        checkout.DoCheckout();
    }
}