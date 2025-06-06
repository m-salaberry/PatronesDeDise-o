using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Auto : IVehiculo
    {
        public void Bocina()
        {
            Console.WriteLine("Conduciendo un auto de cuatro ruedas.");
        }

        public void Conducir()
        {
            Console.WriteLine("¡Beep beep!");
        }
    }
}
