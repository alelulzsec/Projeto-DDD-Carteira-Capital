using DDDCarteira.Domain.Account.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Mappings
{
    class BrokerMap : EntityTypeConfiguration<DDDCarteira.Domain.Account.Entities.Broker>
    {
        public BrokerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.CNPJ).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Phone).IsRequired().HasMaxLength(11).IsFixedLength();

        }

        private object Property(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        private void HasKey(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
