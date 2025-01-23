namespace Factory_sample
{
    public interface IVehicle
    {
        void Drive();
    }

    // Implementacja samochodu
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Jedziesz samochodem!");
        }
    }

    // Implementacja roweru
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Jedziesz rowerem!");
        }
    }
}
