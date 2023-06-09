namespace _06_FlyWeightPattern
{
    public interface IShape
    {
        public void Draw(int x, int y);


    }

    public class Line : IShape
    {
        public Line()
        {
            Console.WriteLine("Line constructor executed.");
        }
        public void Draw(int x, int y)
        {
            Console.WriteLine($"Draw a Line with:{x},{y}");
        }
    }
    public class Circle : IShape
    {
        public Circle()
        {
            Console.WriteLine("Circle constructor executed.");
        }
        public void Draw(int x, int y)
        {
            Console.WriteLine($"Circle a Line with:{x},{y}");
        }
    }

    public enum ShapeTypes
    {
        Line = 0,
        Circle = 1,
    }

    public class ShapFactory
    {
        public Dictionary<ShapeTypes, IShape> _shapes = new Dictionary<ShapeTypes, IShape>();

        /// <summary>
        /// this shapefactory class on the construction state, first, it will look if the shape has been created before or not.
        //_shapes dictionary will hold 
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public IShape Getshape(ShapeTypes shapeType)
        {
            if (shapeType == ShapeTypes.Line)
            {
                var line = _shapes.FirstOrDefault(x => x.Key == ShapeTypes.Line).Value;
                if (line == null)
                {
                    line = new Line();
                    _shapes.Add(ShapeTypes.Line, line);
                }
                return line;
            }
            else if (shapeType == ShapeTypes.Circle)
            {
                var circle = _shapes.FirstOrDefault(x => x.Key == ShapeTypes.Circle).Value;
                if (circle == null)
                {
                    circle = new Line();
                    _shapes.Add(ShapeTypes.Circle, circle);
                }
                return circle;
            }
            return null;
        }


    }

}
