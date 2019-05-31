using DDDCarteira.Domain.Account.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Domain.Account.Repositories
{
    public interface ICustomerRepository{
        Customer GetByID(Guid id);
        void Save(Customer customer);
        IEnumerable<Customer> GetCustomers();
        object GetById(Guid guid);
    }
}
