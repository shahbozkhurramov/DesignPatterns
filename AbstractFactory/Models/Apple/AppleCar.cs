using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Models.Apple
{
    public class AppleCar : ICar
    {
        public string Name => "AppleCar";

        public int Wheels => 4;

        public void Action()
        {
            Console.WriteLine("AppleCar is moving");
        }
    }
}
