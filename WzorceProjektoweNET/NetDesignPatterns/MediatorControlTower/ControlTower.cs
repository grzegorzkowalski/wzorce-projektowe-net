using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorControlTower
{
    public interface IControlTower
    {
        void SendRequest(string request, Airplane airplane);
        void AddAirplane(Airplane airplane);
    }

    // Konkretna klasa mediatora (Wieża Kontroli Lotów)
    public class ControlTower : IControlTower
    {
        private List<Airplane> _airplanes = new List<Airplane>();

        public void AddAirplane(Airplane airplane)
        {
            _airplanes.Add(airplane);
        }

        public void SendRequest(string request, Airplane sender)
        {
            foreach (var airplane in _airplanes)
            {
                if (airplane != sender)
                {
                    airplane.ReceiveRequest(request);
                }
            }
        }
    }

    // Abstrakcyjna klasa samolotu
    public abstract class Airplane
    {
        protected IControlTower _controlTower;
        protected string _identifier;

        public Airplane(IControlTower controlTower, string identifier)
        {
            _controlTower = controlTower;
            _identifier = identifier;
        }

        public abstract void SendRequest(string request);
        public abstract void ReceiveRequest(string request);
    }

    // Konkretna klasa samolotu
    public class PassengerAirplane : Airplane
    {
        public PassengerAirplane(IControlTower controlTower, string identifier) : base(controlTower, identifier) { }

        public override void SendRequest(string request)
        {
            Console.WriteLine($"{_identifier} wysyła żądanie: {request}");
            _controlTower.SendRequest(request, this);
        }

        public override void ReceiveRequest(string request)
        {
            Console.WriteLine($"{_identifier} otrzymał żądanie: {request}");
        }
    }
}
