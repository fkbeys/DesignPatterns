namespace _01_AdapterPattern.Models
{
    public interface IPayment
    {
        public bool MakePayment(int amount);
    }

    public class PayPal : IPayment
    {
        public bool MakePayment(int amount)
        {
            Console.WriteLine("Paypal Payment okey...");
            return true;
        }
    }
    public class Klarna
    {
        public bool Charge(int amount)
        {
            Console.WriteLine("Klarna payment okey...");
            return true;
        }
    }

    public class KlarnaAdapter : IPayment
    {
        private readonly Klarna _klarna;

        public KlarnaAdapter(Klarna klarna)
        {
            this._klarna = klarna;
        }

        public bool MakePayment(int amount)
        {
            return _klarna.Charge(amount);
        }
    }

    public class ShoppingOperations
    {
        private readonly IPayment payment;

        public ShoppingOperations(IPayment payment)
        {
            this.payment = payment;
        }

        public void CheckOut(int amount)
        {
            var result = payment.MakePayment(amount);
            if (result)
            {
                Console.WriteLine("Payment Ok");
            }
            else
            {
                Console.WriteLine("Payment Error");
            } 
        }

    }


}
