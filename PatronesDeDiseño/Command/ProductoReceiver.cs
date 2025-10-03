using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ProductoReceiver
    {
        public double Cantidad { get; set; }
        public string Nombre { get; set; }

        public void RestarStock(double cantidad)
        {
            Cantidad -= cantidad;
            Console.WriteLine($"Se restaron {cantidad} unidades del producto {Nombre}. Stock actual: {Cantidad}");
        }

        public void SumarStock(double cantidad)
        {
            Cantidad += cantidad;
            Console.WriteLine($"Se sumaron {cantidad} unidades del producto {Nombre}. Stock actual: {Cantidad}");
        }
    }
}
