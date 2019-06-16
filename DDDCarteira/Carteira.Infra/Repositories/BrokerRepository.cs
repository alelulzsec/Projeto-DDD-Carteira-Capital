using Carteira.Infra.Contexts;
using Carteira.Infra;
using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Repositories
{
    public class BrokerRepository : IBrokerRepository
    {
        public IEnumerable<Broker> GetBrokers()
        {
            throw new NotImplementedException();
        }

        public Broker GetById()
        {
            throw new NotImplementedException();
        }

        public object GetbyId(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void Save(Broker broker)
        {
            throw new NotImplementedException();
        }

        public class BrokerRepository : IBrokerRepository
        {
            private readonly StoreDataContext _context;

            public BrokerRepository(StoreDataContext context)
            {
                _context = context;
            }

            public Broker GetById(Guid id)
            {
                return _context.Brokers.AsNoTracking().FirstOrDefault(x => x.Id == id);
            }

            public void Save(Broker broker)
            {
                _context.Brokers.Add(broker);
                _context.SaveChanges();
            }

            public IEnumerable<Broker> GetCarriers()
            {
                return _context.Brokers.ToList();
            }

            public void Delete(Guid id)
            {
                var broker = _context.Brokers.Find(id);

                _context.Brokers.Remove(broker);
                _context.SaveChanges();
            }

            Broker IBrokerRepository.GetById()
            {
                throw new NotImplementedException();
            }

            void IBrokerRepository.Save(Broker broker)
            {
                throw new NotImplementedException();
            }

            IEnumerable<Broker> IBrokerRepository.GetBrokers()
            {
                throw new NotImplementedException();
            }

            object IBrokerRepository.GetbyId(Guid guid)
            {
                throw new NotImplementedException();
            }
        }
}