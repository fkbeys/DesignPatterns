using _01_AdapterPattern.Models;

namespace _01_AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingOperations shoppingOperations = new ShoppingOperations(new PayPal {  });
            shoppingOperations.CheckOut(100);
            


            Console.WriteLine("Hello, World!");
        }
    }
}