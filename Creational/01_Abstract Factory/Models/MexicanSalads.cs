namespace _01_Abstract_Factory.Models
{
    public class MexicanSalads : ISalad
    {
        public void Prepare()
        {
            Console.WriteLine("Mexican traditional salats prepared");
        }
    }
}
