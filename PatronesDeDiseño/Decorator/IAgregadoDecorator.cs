﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AgregadoDecorator: BebidaComponent
    {

        protected BebidaComponent _bebida;
        public AgregadoDecorator(BebidaComponent bebida)
        {
            _bebida = bebida;
        }

    }
}
