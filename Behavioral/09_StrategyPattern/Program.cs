namespace _09_StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape shp = new Shape(new DrawCircle());
            shp.Drow();
            shp.Drow();
            shp.SetDrawStrategy(new DrawRectangle());
            shp.Drow();
            shp.SetDrawStrategy(new TriangleRectangle());
            shp.Drow();



            Console.Read();
        }
    }
}