﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Leche: AgregadoDecorator
    {
        public Leche(BebidaComponent bebida) : base(bebida)
        {
        }

        public override double Costo => _bebida.Costo + 2;
        public override string Descripcion => _bebida.Descripcion + ", con leche";

    }
}
