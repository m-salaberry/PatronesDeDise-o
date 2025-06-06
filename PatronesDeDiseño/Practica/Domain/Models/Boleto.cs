using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Domain.Models
{
    public abstract class Boleto
    {
        public Guid Id { get; set; }
        public double CostoEmbarque { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Numero { get; }
        public int TiempoEnDias { get; set; }

        public Boleto(int numBoleto)
        {
            Numero = numBoleto;
            CostoEmbarque = 9950;
        }

        public DateTime CalcularRegreso()
        {
            return FechaSalida.AddDays(TiempoEnDias);
        }

        public abstract double CostoBoleto();
    }
}
