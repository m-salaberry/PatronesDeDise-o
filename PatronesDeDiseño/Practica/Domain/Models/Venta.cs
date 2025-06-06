using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Domain.Models
{
    public class Venta
    {
        public Guid Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public List<Boleto> BoletosVendidos = new List<Boleto>();

        public bool Agregar(Boleto boleto)
        {
            BoletosVendidos.Add(boleto);
            return true;
        }

        public bool Actualizar(Boleto boleto)
        {
            var index = BoletosVendidos.FindIndex(b => b.Id == boleto.Id);
            if (index >= 0)
            {
                BoletosVendidos[index] = boleto;
                return true;
            }
            return false;

        }
    }
}
