using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorNaftero : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor nafta");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor nafta");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando combustible en el motor nafta");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el motor nafta");
        }
    }
}
