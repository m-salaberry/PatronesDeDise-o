﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Director: Aprobador
    {
        public override void Procesar(Compra c)
        {
            Console.WriteLine(string.Format("Compra aprobada por el {0}", this.GetType().Name));
        }

    }
}
