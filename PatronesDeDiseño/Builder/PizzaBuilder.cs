using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class PizzaBuilder
    {

        protected string descripcion;
        public abstract Masa BuildMasa();
        public abstract Salsa BuildSalsa();
        public abstract Agregado BuildAgregado();

        public override string ToString()
        {
            return descripcion;
        }

        public Pizza BuildPizza()
        {
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            Agregado agregado = BuildAgregado();
            return new Pizza(masa, salsa, agregado, descripcion);
        }

    }
}
