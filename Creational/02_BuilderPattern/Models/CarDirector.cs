namespace _02_BuilderPattern.Models
{
    public class CarDirector
    {

        public Car BuildSportCar()
        {
            return new CarBuilder().SetColor($"Red").SetEnginePower(4000).SetInterior("Red").Build();
        }

        public Car BuildFamilyCar()
        {
            return new CarBuilder().SetColor("FamilyCar:Yellow").Build();
        }

    }
}
