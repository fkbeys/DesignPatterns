namespace _10_TemplateMethodPattern
{
    public abstract class Drink
    {
        public void PrepareDrink()
        {
            BoilTheWather();
            Brew();
            FillTheCup();
            Serve();
        }

        private void BoilTheWather()
        {
            Console.WriteLine("Water boiled");
        }
        public abstract void Brew();
        private void FillTheCup()
        {
            Console.WriteLine("Filling the cup.");
        }
        public abstract void Serve();

    }

    public class Tea : Drink
    {
        public override void Brew()
        {
            Console.WriteLine("Tea brewed");
        }


        public override void Serve()
        {
            Console.WriteLine("Tea served");
        }
    }

    public class Coffea : Drink
    {
        public override void Brew()
        {
            Console.WriteLine("Coffea brewed");
        }


        public override void Serve()
        {
            Console.WriteLine("Coffea served.");
        }
    }



}
