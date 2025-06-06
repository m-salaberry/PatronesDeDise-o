using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaCancha : Pizza
    {
        public PizzaCancha(string origen) {
            _descripcion = "Piiza Cancha";
            _origen = origen;
        }

    }
}
