namespace _04_DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract decimal Price();
    }

    public class Espresso : Beverage
    {
        public override string Description => "Espresso";

        public override decimal Price()
        {
            return 5;
        }
    }

    public abstract class BeverageDecorator : Beverage
    {
        public readonly Beverage _beverage;

        public BeverageDecorator(Beverage beverage)
        {
            this._beverage = beverage;
        }
    }

    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => _beverage.Description + " With Milk";

        public override decimal Price()
        {
            return _beverage.Price() + 1;
        }
    }


}
