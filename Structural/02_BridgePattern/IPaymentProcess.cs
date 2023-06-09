namespace _02_BridgePattern
{
    public interface IPaymentProcess
    {
        public bool MakePayment(decimal amount);
    }

    public class Paypal : IPaymentProcess
    {
        private readonly string username;
        private readonly string password;

        public Paypal(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool MakePayment(decimal amount)
        {
            Console.WriteLine($"Payment succeed with Paypal:{amount} Euro.");
            return true;
        }
    }


    public class Stripe : IPaymentProcess

    {
        public bool MakePayment(decimal amount)
        {
            Console.WriteLine($"Payment succeed with Stripe:{amount} Euro.");
            return true;
        }
    }

    public class PaymentProcess
    {
        public IPaymentProcess _paymentProcess;

        public PaymentProcess(IPaymentProcess paymentProcess)
        {
            _paymentProcess = paymentProcess;
        }

        public bool MakePayment(decimal amount)
        {
            return _paymentProcess.MakePayment(amount);
        }


    }



}
