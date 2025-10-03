using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class OrdenCommand
    {
        public abstract void Ejecutar();

        protected ProductoReceiver producto;
        protected double cantidad;

        public OrdenCommand(ProductoReceiver producto, double cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }
    }
}
