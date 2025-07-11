using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Verificaciones
    {
        protected Cliente _cliente;

        public void Verificar()
        {
            var msg = new List<string>();
            msg.Add($"Verficando credito para {_cliente.Nombre}");
            msg.Add(VerificarAcciones());
            msg.Add(VerificarBalance());
            msg.Add(VerificarCreditos());
            msg.Add(VerificarIngresos());

            foreach (var m in msg)
            {
                Console.WriteLine(m);
            }
        }

        //Van a ser implementadas en clases de bajo nivel
        protected abstract string VerificarAcciones();
        protected abstract string VerificarBalance();
        protected abstract string VerificarIngresos();
        protected abstract string VerificarCreditos();

    }
}
