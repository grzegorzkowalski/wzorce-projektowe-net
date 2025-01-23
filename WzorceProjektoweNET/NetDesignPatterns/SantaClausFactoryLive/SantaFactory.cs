using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClausFactoryLive
{
    internal class SantaFactory
    {
        internal Gift CreateToy(string toyName)
        {
            Console.WriteLine($"Tworzenie zabawki: {toyName}");
            return new Toy(toyName);
        }

        internal Gift CreateRod(string rodName)
        {
            Console.WriteLine($"Tworzenie rózgi: {rodName}");
            return new Rod(rodName);
        }
    }
}
