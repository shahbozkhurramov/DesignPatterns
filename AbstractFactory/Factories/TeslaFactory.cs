using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Models.Tesla;

namespace AbstractFactoryPattern.Factories
{
    public class TeslaFactory : IProductFactory
    {
        public ICar CreateCar() => new Tesla();

        public ISmartPhone CreateSmartPhone() => new TeslaPhone();
    }
}
