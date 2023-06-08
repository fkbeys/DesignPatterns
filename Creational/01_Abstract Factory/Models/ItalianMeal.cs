namespace _01_Abstract_Factory.Models
{
    public class ItalianMeal : IMeal
    {
        public void Prepare()
        {
            Console.WriteLine("Italian tradational foods prepared...");
        }
    }
}
