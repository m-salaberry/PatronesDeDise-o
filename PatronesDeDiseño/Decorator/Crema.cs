﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Crema: AgregadoDecorator
    {
        public Crema(BebidaComponent bebida) : base(bebida)
        {
        }
        public override double Costo => _bebida.Costo + 5;
        public override string Descripcion => _bebida.Descripcion + ", con crema";
    }
}
