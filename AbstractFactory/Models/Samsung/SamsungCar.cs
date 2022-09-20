using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Models.Samsung
{
    internal class SamsungCar : ICar
    {
        public string Name => "Samsung";

        public int Wheels => 4;

        public void Action()
        {
            Console.WriteLine("Samsung car is moving");
        }
    }
}
