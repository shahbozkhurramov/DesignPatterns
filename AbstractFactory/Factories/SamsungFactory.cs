using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Models.Samsung;

namespace AbstractFactoryPattern.Factories
{
    public class SamsungFactory : IProductFactory
    {
        public ICar CreateCar() => new SamsungCar();

        public ISmartPhone CreateSmartPhone() => new Samsung();
    }
}
