using DDDCarteira.Domain.Account.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Domain.Account.Repositories
{
   public interface IBrokerRepository{
        Broker GetById(Guid newId);
        void Save(Broker broker);
        IEnumerable<Broker> GetBrokers();
        object GetbyId(Guid guid);
    }
}
