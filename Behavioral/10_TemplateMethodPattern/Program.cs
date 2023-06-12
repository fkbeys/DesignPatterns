namespace _10_TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drnk = new Tea();
            drnk.PrepareDrink();

            drnk = new Coffea();
            drnk.PrepareDrink();

            Console.ReadLine();
        }
    }
}