namespace _04_DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Espresso espresso = new Espresso();
            BeverageDecorator decorator = new Milk(espresso);


            Console.WriteLine("Name:" + decorator.Description + "Price: " + decorator.Price());

            Console.ReadLine();
        }
    }
}