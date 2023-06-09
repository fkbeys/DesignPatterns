namespace _01_ChainOfResponsibility
{
    public class Sale
    {
        public Sale(int amount)
        {
            this.amount = amount;
            Console.WriteLine("Sale class instance created...");
        }

        public double amount { get; set; }
        public double discount { get; set; }
        public double finalDiscount { get; set; }

    }

    public abstract class DiscountHandler
    {
        protected DiscountHandler nextHandler;
        public void SetNextHandler(DiscountHandler handler)
        {
            nextHandler = handler;
        }
        public abstract void ApplyDiscount(Sale sale);

    }

    public class FivePercentDiscountHandler : DiscountHandler
    {
        public override void ApplyDiscount(Sale sale)
        {
            if (sale.amount < 200)
            {
                sale.discount = sale.amount * 5 / 100;
                sale.finalDiscount = sale.amount - sale.discount;
                Console.WriteLine("Five Percent Disc Hand. Final:" + sale.finalDiscount);
            }
            else if (nextHandler != null)
            {
                Console.WriteLine("Five Percent Disc Hand. passed the discount to the next handlerer.");
                nextHandler.ApplyDiscount(sale);
            }
        }
    }

    public class TenPercentDiscountHandler : DiscountHandler
    {
        public override void ApplyDiscount(Sale sale)
        {
            if (sale.amount >= 200)
            {
                sale.discount = sale.amount * 10 / 100;
                sale.finalDiscount = sale.amount - sale.discount;
                Console.WriteLine("Ten Percent Disc Hand. Final:" + sale.finalDiscount);
            }
            else if (nextHandler != null)
            {
                Console.WriteLine("Ten Percent Disc Hand. passed the discount to the next handlerer.");
                nextHandler.ApplyDiscount(sale);
            }
        }
    }



}
