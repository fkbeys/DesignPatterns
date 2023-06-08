namespace _01_Abstract_Factory.Models
{
    public class MexicanMeal : IMeal
    {
        public void Prepare()
        {
            Console.WriteLine("Mexican traditional meals are prepared");
        }
    }
}
