﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Azucar : AgregadoDecorator
    {
        public Azucar(BebidaComponent bebida) : base(bebida)
        {
        }
        public override double Costo => _bebida.Costo + 0.5;
        public override string Descripcion => _bebida.Descripcion + ", con azucar";
    }
}
