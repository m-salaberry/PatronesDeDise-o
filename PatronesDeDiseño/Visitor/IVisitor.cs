using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        void Visitar(Motherboard motherboard);
        void Visitar(Procesador procesador);
        void Visitar(DiscoDuro discoDuro);
    }
}
