using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEjemplo2
{
    public class Ingrediente : Component
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
        public Ingrediente(string nombre, double costo, int cantidad, string unidad) : base(nombre, costo)
        {
            this.Cantidad = cantidad;
            this.Unidad = unidad;
        }
    }
}
