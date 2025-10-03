using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class DiscoDuro: Componente
    {
        public DiscoDuro(string serial) : base(serial)
        {
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }

}
