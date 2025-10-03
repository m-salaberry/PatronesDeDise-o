using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class FiatPrototype: AutoPrototype
    {

        public override AutoPrototype Clonar()
        {
            return (AutoPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Fiat {modelo}, Color: {color}";
        }

    }
}
