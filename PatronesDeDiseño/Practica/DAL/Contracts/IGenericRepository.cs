using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        //Operaciones basicas para un ABM
        IEnumerable<T> GetAll();

        T GetById(Guid id);

        bool Insert(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        bool Exists(Guid id);

    }
}
