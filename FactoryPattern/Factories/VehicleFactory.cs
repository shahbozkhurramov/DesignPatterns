using FactoryPattern.Interfaces;
using FactoryPattern.Models;

namespace FactoryPattern.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicleByName(string vehicleName)
        {
            switch (vehicleName)
            {
                case "Car":
                    return new Car();
                case "Bike":
                    return new Bike();
                case "Truck":
                    return new Truck();
                default:
                    return null;
            }
        }
    }
}
