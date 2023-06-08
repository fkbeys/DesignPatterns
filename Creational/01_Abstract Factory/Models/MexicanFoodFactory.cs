namespace _01_Abstract_Factory.Models
{
    public class MexicanFoodFactory : IFoodFactory
    {
        public IMeal PrepareMeal()
        {
            return new MexicanMeal();
        }

        public ISalad PrepareSalat()
        {
            return new MexicanSalads();
        }
    }
}
