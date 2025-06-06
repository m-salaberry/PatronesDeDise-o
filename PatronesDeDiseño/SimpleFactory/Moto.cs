using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Moto : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("Conduciendo una moto de dos ruedas.");
        }

        public void Bocina()
        {
            Console.WriteLine("¡Pip pip!");
        }
    }
}
