namespace _02_BuilderPattern.Models
{
    public class CarBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public CarBuilder SetColor(string color)
        {
            car.color = color;
            return this;
        }

        public CarBuilder SetEnginePower(int power)
        {
            car.enginePower = power;
            return this;
        }
        public CarBuilder SetInterior(string interior)
        {
            car.interior = interior;
            return this;
        }

        public Car Build()
        {
            Console.WriteLine($"Car Properties:{car.color},{car.enginePower},{car.interior}");
            return car;
        }


    }
}
