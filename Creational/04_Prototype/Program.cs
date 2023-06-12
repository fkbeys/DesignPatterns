using _04_Prototype.Models;

namespace _04_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Toyota", "Corolla", 2011);
            var prototype = new CarPrototype(car);

            var newCar1 = prototype.Copy();
            var newCar2 = prototype.Copy();


            Console.ReadLine();
        }
    }
}