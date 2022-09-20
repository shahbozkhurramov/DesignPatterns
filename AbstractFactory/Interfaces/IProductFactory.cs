namespace AbstractFactoryPattern.Interfaces
{
    public interface IProductFactory
    {
        ICar CreateCar();

        ISmartPhone CreateSmartPhone();
    }
}
