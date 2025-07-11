using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CafeExpreso : BebidaComponent
    {
        public override double Costo => 12;

        public override string Descripcion => "Cafe expresso";
    }
}
