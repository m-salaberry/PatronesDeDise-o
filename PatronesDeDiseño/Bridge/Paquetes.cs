using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Paquetes
    {
        protected IMedio medioEntrega;

        public Paquetes(IMedio medio)
        {
            medioEntrega = medio;
        }
        public abstract void entrega();
    }
}
