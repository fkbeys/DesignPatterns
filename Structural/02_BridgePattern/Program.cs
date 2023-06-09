namespace _02_BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paypalx = new Paypal("Kaya", "1234");


            var proc = new PaymentProcess(paypalx);
            var result = proc.MakePayment(100);

            if (result == false)
            {
                var stripe = new Stripe();
                proc = new PaymentProcess(stripe);
                proc.MakePayment(102);
            }

            Console.ReadLine();
        }
    }
}