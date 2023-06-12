using _01_Abstract_Factory.Models;

namespace _01_Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IFoodFactory foodFactory = new ItalianFoodFactory();

            IMeal meal = foodFactory.PrepareMeal();
            meal.Prepare();

            ISalad salad = foodFactory.PrepareSalat();
            salad.Prepare();

            foodFactory = new MexicanFoodFactory();

            meal = foodFactory.PrepareMeal();
            meal.Prepare();

            salad = foodFactory.PrepareSalat();
            salad.Prepare();

            //IFoodFactory italianFoodFactory = new ItalianFoodFactory();

            //IMeal italianMeal = italianFoodFactory.PrepareMeal();
            //italianMeal.Prepare();

            //ISalad italianSalad = italianFoodFactory.PrepareSalat();
            //italianSalad.Prepare();


            Console.ReadLine();
        }
    }
}