using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Car : IVehicle
    {
        public string Name => "Car";

        public int Wheels => 4;

        public void Action()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
