using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Models.Apple
{
    public class Iphone : ISmartPhone
    {
        public string Name => "Iphone";

        public string Price => "1000$";

        public void Action()
        {
            Console.WriteLine("Iphone is calling");
        }
    }
}
