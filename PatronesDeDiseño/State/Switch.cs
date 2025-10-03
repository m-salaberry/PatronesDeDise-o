using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Switch
    {
        Estado estado;

        public Switch()
        {
            estado = new Encendido();
        }

        public void DefinirEstado(Estado estado)
        {
            this.estado = estado;
        }

        public void Presionar()
        {
            estado.ControlarEstado(this);
            Console.WriteLine(estado.Describir());
        }
    }
}
