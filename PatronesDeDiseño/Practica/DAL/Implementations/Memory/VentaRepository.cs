using Practica.DAL.Contracts;
using Practica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.DAL.Implementations.Memory
{
    public class VentaRepository : IVentaRepository
    {
        private readonly Dictionary<Guid, Boleto> _boletos = new Dictionary<Guid, Boleto>();

        public bool Delete(Boleto entity)
        {
            if (!_boletos.ContainsKey(entity.Id))
            {
                Console.WriteLine($"No se puede Eliminar. Boleto no encontrado con ID {entity.Id}");
                return false;
            }
            _boletos.Remove(entity.Id);
            Console.WriteLine("Boleto eliminado correctamente");
            return true;
        }

        public bool Exists(Guid id)
        {
            if (_boletos.ContainsKey(id))
            {
                return true;
            }
            Console.WriteLine($"Boleto no encontrado con ID {id}");
            return false;
        }

        public IEnumerable<Boleto> GetAll()
        {
            return _boletos.Values.ToList();
        }

        public Boleto GetById(Guid id)
        {
            if (_boletos.TryGetValue(id, out var boleto))
            {
                Console.WriteLine("Boleto encontrado");
                return boleto;
            }

            throw new KeyNotFoundException($"No se encontró un boleto con ID {id}");
        }

        public bool Insert(Boleto entity)
        {
            entity.Id = Guid.NewGuid(); // Asignar un nuevo ID al boleto
            if (_boletos.ContainsKey(entity.Id))
            {
                Console.WriteLine($"No se puede insertar. El boleto ya existe con ID {entity.Id}");
                return false;
            }
            _boletos[entity.Id] = entity;
            Console.WriteLine("Boleto guardado correctamente");
            return true;
        }

        public bool Update(Boleto entity)
        {
            if (!_boletos.ContainsKey(entity.Id))
            {
                Console.WriteLine($"No se puede Actualizar. Boleto no encontrado con ID {entity.Id}");
                return false;
            }

            _boletos[entity.Id] = entity;
            Console.WriteLine("Boleto actualizado correctamente");
            return true;
        }
    }
}
