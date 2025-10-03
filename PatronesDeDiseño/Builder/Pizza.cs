using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        Masa masa;
        Salsa salsa;
        Agregado agregado;
        string tipo;

        public override string ToString()
        {
            return $"{tipo}, Masa: {masa}, Salsa: {salsa}, Agregado: {agregado}";
        }

        public Pizza(Masa masa, Salsa salsa, Agregado agregado, string tipo)
        {
            this.masa = masa;
            this.salsa = salsa;
            this.agregado = agregado;
            this.tipo = tipo;
        }


    }
}
