using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PaqueteFragil: Paquetes
    {
        public PaqueteFragil(IMedio medioEntrega) : base(medioEntrega)
        {
        }
        public override void entrega()
        {
            Console.WriteLine("Estoy entregando un paquete frágil");
            medioEntrega.tiempoEntrega();
        }
    }
}
