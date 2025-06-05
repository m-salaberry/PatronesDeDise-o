using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InMemoryRepository<T> : IRepository<T> where T : class, IEntity
    {

        protected readonly List<T> _entities;
        private int _nextId = 1;

        public InMemoryRepository()
        {
            _entities = new List<T>();
        }

        public Task AddAsync(T entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = _nextId++;
            }
            _entities.Add(entity);
            Console.WriteLine($"Se agrego correctamente {entity.ToString()} del tipo {entity.GetType().ToString()}");
            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            _entities.Remove(entity);
            Console.WriteLine($"Se elimino correctamente {entity.ToString()} del tipo {entity.GetType().ToString()}");
            return Task.CompletedTask;
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<T>>(_entities.AsReadOnly());
        }

        public Task<T> GetByIdAsync(int id)
        {
            return Task.FromResult(_entities.FirstOrDefault(x => x.Id == id))!;
        }

        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(0);
        }

        public Task UpdateAsync(T entity)
        {
            var existingEntity = _entities.FirstOrDefault(x => x.Id == entity.Id);
            if (existingEntity != null) 
            {
                var index = _entities.IndexOf(existingEntity);
                if (index != -1)
                {
                    _entities[index] = entity;
                }
            }
            Console.WriteLine($"Se modifico correctamente {entity.ToString()} del tipo {entity.GetType().ToString()}");
            return Task.CompletedTask;
        }
    }
}
