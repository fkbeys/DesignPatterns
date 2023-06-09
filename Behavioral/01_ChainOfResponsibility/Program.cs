namespace _01_ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sale1 = new Sale(100);
            var sale2 = new Sale(400);

            FivePercentDiscountHandler fivePercentDiscountHandler = new FivePercentDiscountHandler();
            TenPercentDiscountHandler tenPercentDiscountHandler = new TenPercentDiscountHandler();
            fivePercentDiscountHandler.SetNextHandler(tenPercentDiscountHandler);
            fivePercentDiscountHandler.ApplyDiscount(sale1);
            fivePercentDiscountHandler.ApplyDiscount(sale2);

            


            Console.ReadLine();

        }
    }
}