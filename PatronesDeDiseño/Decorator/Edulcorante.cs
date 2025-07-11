using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Edulcorante : AgregadoDecorator
    {

        public Edulcorante(BebidaComponent bebida) : base(bebida)
        {
        }
        public override double Costo => _bebida.Costo + 1;
        public override string Descripcion => _bebida.Descripcion + ", con edulcorante";

    }
}
