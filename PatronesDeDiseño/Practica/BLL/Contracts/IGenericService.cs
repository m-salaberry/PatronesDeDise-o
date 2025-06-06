using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.BLL.Contracts
{
    public interface IGenericService<T>
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);

        bool Insert(T entity);

        bool Update(T entity);

        bool Delete(Guid id);

        bool Exists(Guid id);

    }
}
