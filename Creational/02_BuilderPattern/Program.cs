using _02_BuilderPattern.Models;

namespace _02_BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carDirector = new CarDirector();
            carDirector.BuildSportCar();
            carDirector.BuildFamilyCar();

            Console.ReadLine();
        }
    }
}