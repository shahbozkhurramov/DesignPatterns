using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Models.Tesla
{
    public class Tesla : ICar
    {
        public string Name => "Tesla";

        public int Wheels => 4;

        public void Action()
        {
            Console.WriteLine("Tesla is moving");
        }
    }
}
