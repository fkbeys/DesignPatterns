namespace _04_Prototype.Models
{

    public class Car : ICloneable
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public object Clone()
        {
            // return new Car(make, model, year);
            return this.MemberwiseClone();
        }
    }

    public class CarPrototype
    {
        private Car _car;
        public CarPrototype(Car car)
        {
            _car = car;
        }

        public Car Copy()
        {
            Console.WriteLine("Car clone created...");
            return (Car)_car.Clone();
        }

    }

}
