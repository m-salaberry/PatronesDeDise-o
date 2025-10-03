using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MedioCamion: IMedio
    {
        public void tiempoEntrega()
        {
            Console.WriteLine("El tiempo de entrega con Camión es de 3 a 5 días hábiles");
        }
    }
    
}
