using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBattaglia
{
    public class Usuario : IObserverUsuario
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString() {
            return $"{Nombre} {Apellido}";
        }


        public void Actualizar(Producto p)
        {
            Console.WriteLine($"El usuario {this} recibio la notificacion del producto {p}");
        }
    }
}
