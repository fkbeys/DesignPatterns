namespace _06_FlyWeightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapFactory shapFactory = new ShapFactory();
            var factory = shapFactory.Getshape(ShapeTypes.Line);
            factory.Draw(1, 2);


            factory = shapFactory.Getshape(ShapeTypes.Line);
            factory.Draw(3, 4);

            factory = shapFactory.Getshape(ShapeTypes.Circle);
            factory.Draw(5, 6);

            factory = shapFactory.Getshape(ShapeTypes.Circle);
            factory.Draw(7, 8);



            Console.ReadLine();

            Console.WriteLine("Hello, World!");
        }
    }
}