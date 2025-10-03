using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PizzaItalianaBuilder: PizzaBuilder
    {
        public PizzaItalianaBuilder()
        {
            descripcion = "Pizza Italiana";
        }

        public override Agregado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Masa BuildMasa()
        {
            return new ALaPiedra();
        }

        public override Salsa BuildSalsa()
        {
            return new Oliva();
        }
    }
}
