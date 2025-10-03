using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MedioMiniFlete: IMedio
    {
        public void tiempoEntrega()
        {
            Console.WriteLine("El tiempo de entrega con MiniFlete es de 1 a 2 días hábiles");
        }
    }
}
