using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Prestamo: Verificaciones
    {

        public Prestamo(Cliente c)
        {
            _cliente = c;
        }

        protected abstract override string VerificarAcciones();
        protected abstract override string VerificarBalance();
        protected abstract override string VerificarIngresos();
        protected abstract override string VerificarCreditos();

    }
}
