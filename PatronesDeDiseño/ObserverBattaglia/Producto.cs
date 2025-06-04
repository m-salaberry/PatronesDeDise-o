using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBattaglia
{
    public class Producto : ISujetoProducto
    {

        private List<IObserverUsuario> _usuarios;
        public string Nombre { get; set; }

        double _precio;

        public Producto(string nombre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            Nombre = nombre;
            _precio = precio;
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
                this.Notificar();
            }
        }

        public override string ToString()
        {
            return $"{Nombre} (${Precio})";
        }


        public void Agregar(IObserverUsuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripcion para {((Usuario) usuario)}");
            }
        }

        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception($"No existe una suscripcion para {((Usuario)usuario)}");
            }
        }

        public void Notificar()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.Actualizar(this);
            }

            if (_usuarios.Count == 0)
            {
                Console.WriteLine("No hay suscripciones");
            }

            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }
}
