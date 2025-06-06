using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {

        protected  string _descripcion { get; set; }
        protected string _origen {  get; set; }

        public void Render()
        {
            Console.WriteLine($"Pizza de {_descripcion} hecha en {_origen}");
        }
    }
}
