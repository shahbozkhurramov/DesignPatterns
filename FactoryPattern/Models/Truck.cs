using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Truck : IVehicle
    {
        public string Name => "Truck";

        public int Wheels => 6;

        public void Action()
        {
            Console.WriteLine("Truck is moving");
        }
    }
}
