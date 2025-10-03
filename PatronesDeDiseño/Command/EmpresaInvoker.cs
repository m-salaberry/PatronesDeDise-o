using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class EmpresaInvoker
    {
        private List<OrdenCommand> ordenes = new List<OrdenCommand>();
        public void AgregarOrden(OrdenCommand orden)
        {
            ordenes.Add(orden);
        }
        public void ProcesarOrdenes()
        {
            foreach (var orden in ordenes)
            {
                orden.Ejecutar();
            }
            ordenes.Clear();
        }
    }
}
