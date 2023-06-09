namespace _03_Factory.Models
{
    public class Blog : Page
    {
        public override void CreateWebPage()
        {
            Console.WriteLine($"Blog web site builded ");
        }
    }
}
