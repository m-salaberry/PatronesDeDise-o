using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEjemplo2
{
    public abstract class Component
    {

        public string Nombre { get; set; }

        public double Costo { get; set; }

        public Component(string nombre, double costo)
        {
            this.Nombre = nombre;
            this.Costo = costo;
        }
    }
}
