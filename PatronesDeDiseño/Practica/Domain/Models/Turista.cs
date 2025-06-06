using Practica.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Domain.Models
{
    public class Turista : Boleto
    {
        public Turista(int numBoleto) : base(numBoleto)
        {
            
        }
        public override double CostoBoleto()
        {
            return CostoEmbarque + Convert.ToDouble(TipoBoleto.Turista);
        }
    }
}
