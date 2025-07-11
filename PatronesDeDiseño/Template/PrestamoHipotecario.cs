using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class PrestamoHipotecario: Prestamo
    {
        public override string ToString()
        {
            return "Prestamo Hipotecario";
        }
        public PrestamoHipotecario(Cliente c) : base(c)
        {
        }
        protected override string VerificarAcciones()
        {
            return $"Verificando acciones del cliente para un {this.ToString()}";
        }
        protected override string VerificarBalance()
        {
            return $"Verificando balance del cliente para un {this.ToString()}";
        }
        protected override string VerificarIngresos()
        {
            return $"Verificando ingresos del cliente para un {this.ToString()}";
        }
        protected override string VerificarCreditos()
        {
            return $"Verificando creditos del cliente para un {this.ToString()}";
        }

    }
}
