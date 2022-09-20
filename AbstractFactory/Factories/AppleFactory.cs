using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Models.Apple;

namespace AbstractFactoryPattern.Factories
{
    public class AppleFactory : IProductFactory
    {
        public ICar CreateCar() => new AppleCar();

        public ISmartPhone CreateSmartPhone() => new Iphone();
    }
}
