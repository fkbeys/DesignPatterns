namespace _01_Abstract_Factory.Models
{
    public class ItalianFoodFactory : IFoodFactory
    {
        public IMeal PrepareMeal()
        {
            return new ItalianMeal();
        }

        public ISalad PrepareSalat()
        {
            return new ItaliandSalad();
        }
    }
}
