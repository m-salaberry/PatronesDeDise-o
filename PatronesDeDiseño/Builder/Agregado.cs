using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Agregado
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }
    }

    public class Oregano : Agregado
    {
        public Oregano()
        {
            descripcion = "Oregano";
        }
    }
    
    public class Anchoas : Agregado
    {
        public Anchoas()
        {
            descripcion = "Anchoas";
        }
    }

    public class Berenjenas : Agregado
    {
        public Berenjenas()
        {
            descripcion = "Berenjenas";
        }
    }
}
