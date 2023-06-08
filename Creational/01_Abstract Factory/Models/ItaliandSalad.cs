namespace _01_Abstract_Factory.Models
{
    public class ItaliandSalad : ISalad
    {
        public void Prepare()
        {
            Console.WriteLine("Italian traditional salad prepared...");
        }
    }
}
