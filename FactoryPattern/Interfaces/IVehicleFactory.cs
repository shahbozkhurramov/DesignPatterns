namespace FactoryPattern.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicleByName(string vehicleName);
    }
}
