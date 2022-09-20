namespace FactoryPattern.Interfaces
{
    public interface IVehicle
    {
        string Name { get; }

        int Wheels { get; }

        void Action();
    }
}
