namespace AbstractFactoryPattern.Interfaces
{
    public interface ICar
    {
        string Name { get; }

        int Wheels { get; }

        void Action();
    }
}
