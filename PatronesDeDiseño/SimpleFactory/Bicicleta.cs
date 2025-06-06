using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Bicicleta : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("Pedaleando una bicicleta.");
        }

        public void Bocina()
        {
            Console.WriteLine("¡Ring ring!");
        }
    }
}
