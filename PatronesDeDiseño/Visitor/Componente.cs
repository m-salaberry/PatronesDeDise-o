using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Componente
    {
        string serial;

        public Componente(string serial)
        {
            this.serial = serial;
        }

        public string Serial { get { return serial; } }

        public abstract void Accept(IVisitor visitor);
    }
}
