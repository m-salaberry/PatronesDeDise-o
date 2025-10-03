using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        IRepository real;

        public IList<Customer> GetAll()
        {
            if (real == null)
            {
                real = new CustomerRepository();
            }
            if (Session.CanGetAll)
            {
                return real.GetAll();
            }
            else
            {
                throw new UnauthorizedAccessException("You are not authorized to get customers");
            }
        }

        public void Save(Customer customer)
        {
            if (real == null)
            {
                real = new CustomerRepository();
            }
            if (Session.CanSave)
            {
                real.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException("You are not authorized to save customers");
            }
        }
    }
}
