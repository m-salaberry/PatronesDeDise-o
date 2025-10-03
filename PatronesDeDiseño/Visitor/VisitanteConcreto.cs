using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class VisitanteConcreto: IVisitor
    {
        public void Visitar(DiscoDuro discoDuro)
        {
            Console.WriteLine($"Visitando Disco Duro con serial {discoDuro.Serial}");
        }
        public void Visitar(Motherboard motherboard)
        {
            Console.WriteLine($"Visitando Motherboard con serial {motherboard.Serial}");
        }
        public void Visitar(Procesador procesador)
        {
            Console.WriteLine($"Visitando Procesador con serial {procesador.Serial}");
        }
    }

    public class VisitanteConcreto2 : IVisitor
    {
        public void Visitar(DiscoDuro discoDuro)
        {
            Console.WriteLine($"El DiscoDuro tiene el siguiente s/n: {discoDuro.Serial}");
        }

        public void Visitar(Motherboard motherboard)
        {
            Console.WriteLine($"La Motherboard tiene el siguiente s/n: {motherboard.Serial}");
        }

        public void Visitar(Procesador procesador)
        {
            Console.WriteLine($"El Procesador tiene el siguiente s/n: {procesador.Serial}");
        }
    }
}
