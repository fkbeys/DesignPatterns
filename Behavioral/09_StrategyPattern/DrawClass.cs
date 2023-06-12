namespace _09_StrategyPattern
{
    public interface IDrawStrategy
    {
        public void Draw();

    }

    public class DrawCircle : IDrawStrategy
    {
        public void Draw()
        {
            Console.WriteLine("Circle is drown");
        }
    }

    public class DrawRectangle : IDrawStrategy
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle is drown");
        }
    }
    public class TriangleRectangle : IDrawStrategy
    {
        public void Draw()
        {
            Console.WriteLine("Triangle is drown");
        }
    }


    public class Shape
    {
        private IDrawStrategy _drawStrategy;

        public Shape(IDrawStrategy drawStrategy)
        {
            this._drawStrategy = drawStrategy;
        }

        public void SetDrawStrategy(IDrawStrategy drawStrategy)
        {
            _drawStrategy = drawStrategy;
        }

        public void Drow()
        {
            _drawStrategy.Draw();
        }

    }


}
