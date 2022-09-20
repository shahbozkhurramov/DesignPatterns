using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Models.Tesla
{
    public class TeslaPhone : ISmartPhone
    {
        public string Name => "Tesla phone";

        public string Price => "$1000";

        public void Action()
        {
            Console.WriteLine("Tesla phone is calling");
        }
    }
}
