using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PizzaLightBuilder: PizzaBuilder
    {
        public PizzaLightBuilder()
        {
            descripcion = "Pizza Light";
        }
        public override Agregado BuildAgregado()
        {
            return new Berenjenas();
        }
        public override Masa BuildMasa()
        {
            return new Integral();
        }
        public override Salsa BuildSalsa()
        {
            return new Light();
        }
    }
}
