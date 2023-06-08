namespace _01_Abstract_Factory
{
    public class fx 
    {
        public interface ICar
        {
            public void Produce();
        }

        public class USCar : ICar { public void Produce() { Console.WriteLine("Car Produced for US"); } }
        public class UKCar : ICar { public void Produce() { Console.WriteLine("Car Produced for UK"); } }
        public class TRCar : ICar { public void Produce() { Console.WriteLine("Türkiye için araç üretildi"); } }

        public interface IAutoFactory
        {
            public ICar ProduceCar();
        }

        public class USAutoFactory : IAutoFactory
        {
            public ICar ProduceCar()
            {
                return new USCar();
            }
        }

        public class UKAutoFactory : IAutoFactory
        {
            public ICar ProduceCar()
            {
                return new UKCar();
            }
        }

        public class TRAutoFactory : IAutoFactory
        {
            public ICar ProduceCar()
            {
                return new TRCar();
            }
        }
        public void naber()
        {
            IAutoFactory autofactory = new TRAutoFactory();
            ICar car = autofactory.ProduceCar();
            car.Produce();
        }
    }
}
