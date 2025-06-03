using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorElectrico
    {

        bool _conectado;
        bool _activo;
        bool _moviendo;

        public void Conectar()
        {
            if (_conectado)
            {
                Console.WriteLine("Imposible conectar un motor electrico ya conectado");
            }
            else
            {
                _conectado = true;
                Console.WriteLine("Motor Conectado");
            }
        }

        public void Activar()
        {
            if (!_conectado) Console.WriteLine("Imposible activar un motor no conectado");
            else
            {
                _activo = true;
                Console.WriteLine("Motor activado");
            }
        }


        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("El motor debera estar conectado y activo");
            }
        }

        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("Imposible parar un vehiculo que no se este moviendo");
            }
        }

        public void Desconectar()
        {
            if (!_activo && _conectado)
            {
                _conectado = false;
                Console.WriteLine("Motor desconectado");
            }
            if (_activo)
            {
                Console.WriteLine("Imposible desconectar un motor activo");
            }
            else
            {
                Console.WriteLine("El motor ya esta desconectado");
            }
        }

        public void Desactivar()
        {
            if (!_activo)
            {
                Console.WriteLine("El motor ya esta desactivado");
            }
            if (_moviendo)
            {
                Console.WriteLine("Imposible desactivar el motor de un vehiculo en movimiento");
            }
            else
            {
                _activo = false;
                Console.WriteLine("Motor desactivado");
            }
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo = false;
                Console.WriteLine("Motor cargando las baterias");
            }
            else
            {
                Console.WriteLine("Imposible enchifar un motor activo");
            }
        }
    }
}
