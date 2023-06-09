namespace _02_BuilderPattern.Models
{
    public class Car
    {
        public Car()
        {
            color = "White";
            enginePower = 1000;
            interior = "Gray";
        }

        public string color { get; set; }
        public int enginePower { get; set; }
        public string interior { get; set; }

    }
}
