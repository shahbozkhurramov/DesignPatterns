using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Bike : IVehicle
    {
        public string Name => "Bike";

        public int Wheels => 2;

        public void Action()
        {
            Console.WriteLine("Bike is moving");
        }
    }
}
