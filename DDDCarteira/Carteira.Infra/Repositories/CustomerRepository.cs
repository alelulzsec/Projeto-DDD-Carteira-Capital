using Carteira.Infra.Contexts;
using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly StoreDataContext _context;

        public CustomerRepository(StoreDataContext context)
        {
            _context = context;
        }

        public Customer GetByID(Guid id)
        {
            return _context.Customers.AsNoTracking().FirstOrDefault(x => x.Id == id);

        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public void Delete(Guid id)
        {
            var customer = _context.Customers.Find(id);

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public object GetById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
