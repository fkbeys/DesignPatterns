namespace _01_Abstract_Factory.Models
{
    public interface IFoodFactory
    {
        public IMeal PrepareMeal();
        public ISalad PrepareSalat();
    }
}
