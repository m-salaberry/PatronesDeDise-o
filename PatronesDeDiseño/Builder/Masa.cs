using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Masa
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }
    }

    public class AlMolde: Masa
    {
        public AlMolde()
        {
            descripcion = "Masa al molde";
        }
    }

    public class ALaPiedra: Masa
    {
        public ALaPiedra()
        {
            descripcion = "Masa a la piedra";
        }
    }

    public class Integral: Masa
    {
        public Integral()
        {
            descripcion = "Masa integral";
        }
    }
}
