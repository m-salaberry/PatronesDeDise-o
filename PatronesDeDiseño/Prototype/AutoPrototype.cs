using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AutoPrototype
    {
        protected string color;
        protected string modelo;

        public string Color { set => color = value; }
        public string Modelo { set => modelo = value; }

        public abstract AutoPrototype Clonar();

        public abstract string VerAuto();
    }
}
