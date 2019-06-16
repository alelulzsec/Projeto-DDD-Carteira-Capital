using System;
using System.Collections.Generic;
using DDDCarteira.Domain.Account.Entities;

namespace Carteira.Infra.Contexts
{
    public class DbSet<T>
    {
        internal object AsNoTracking()
        {
            throw new NotImplementedException();
        }

        internal void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<Customer> ToList()
        {
            throw new NotImplementedException();
        }

        internal object Find(Guid id)
        {
            throw new NotImplementedException();
        }

        internal void Remove(object customer)
        {
            throw new NotImplementedException();
        }

        internal void Add(Broker broker)
        {
            throw new NotImplementedException();
        }
    }
}