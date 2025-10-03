using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PaqueteGeneral: Paquetes
    {
        public PaqueteGeneral(IMedio medioEntrega) : base(medioEntrega)
        {
        }

        public override void entrega()
        {
            Console.WriteLine("Estoy entregando un paquete general");
            medioEntrega.tiempoEntrega();
        }
    }
}
