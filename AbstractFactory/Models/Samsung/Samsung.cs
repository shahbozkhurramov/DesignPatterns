using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Models.Samsung
{
    public class Samsung : ISmartPhone
    {
        public string Name => "Samsung";

        public string Price => "1200$";

        public void Action()
        {
            Console.WriteLine("Samsung is calling");
        }
    }
}
