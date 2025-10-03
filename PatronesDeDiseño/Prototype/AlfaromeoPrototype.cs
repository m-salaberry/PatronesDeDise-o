using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class AlfaromeoPrototype: AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (AutoPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Alfa Romeo {modelo}, Color: {color}";
        }
    }
}
