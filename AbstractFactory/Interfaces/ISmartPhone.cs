namespace AbstractFactoryPattern.Interfaces
{
    public interface ISmartPhone
    {
        string Name { get; }

        string Price { get; }

        void Action();
    }
}
