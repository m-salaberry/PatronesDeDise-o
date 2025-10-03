using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AltaStockCommand: OrdenCommand
    {
        public AltaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {
        }
        public override void Ejecutar()
        {
            producto.SumarStock(cantidad);
        }
    }
}
