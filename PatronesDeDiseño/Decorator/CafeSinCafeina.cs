using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CafeSinCafeina : BebidaComponent
    {
        public override double Costo => 15;

        public override string Descripcion => "Cafe descafeinado";
    }
}
